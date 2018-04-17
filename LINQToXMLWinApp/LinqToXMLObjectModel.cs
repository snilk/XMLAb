using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Xml;
using System.Data.OleDb;

namespace LINQToXMLWinApp
{
    
    class LinqToXMLObjectModel
    {
        private const string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\универ\\6 сем\\БиБД\\xml\\db1.mdb";
        private static XDocument inventoryDoc = null;
        public LinqToXMLObjectModel()
        {

            try
            {
              inventoryDoc= XDocument.Load("SimpleInventory.xml");
                
            }
            catch (Exception)
            {
               
                CreateXMLDocument();
            }
        }
        public static XDocument GetXMLInventory()
        {
            try
            {               
                return XDocument.Load("SimpleInventory.xml");
            }
            catch (System.IO.FileNotFoundException ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static void CreateXMLDocument()
        {
            try
            {
                inventoryDoc =
           new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),
               new XComment("Current inventory of cars"),
               new XProcessingInstruction("xml-stylesheet", "href='MyStyles.css' title='Compact' type='text/css'"),
               new XElement("Inventory",
               new XElement("Car", new XAttribute("ID", 1),
               new XElement("CarId", "1"),
               new XElement("Color", "Green"),
               new XElement("Make", "BMW"),
               new XElement("PetName", "Stan")),
               new XElement("Car", new XAttribute("ID", 2),
               new XElement("CarId", "2"),
               new XElement("Color", "Pink"),
               new XElement("Make", "MRC"),
               new XElement("PetName", "Melvin"))
               ));
                inventoryDoc.Save("SimpleInventory.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void InsertNewElement(string make,string color,string petName)
        {
           inventoryDoc = XDocument.Load("SimpleInventory.xml");
            Random r = new Random();
            int randInt = r.Next(50000);
            XElement newElement = new XElement("Car", new XAttribute("ID", randInt),
                new XElement("CarId",randInt ),
                new XElement("Color", color),
                new XElement("Make", make),
                new XElement("PetName", petName));
            inventoryDoc.Descendants("Inventory").First().Add(newElement);
            inventoryDoc.Save("SimpleInventory.xml");
        }
        public static void LookUpColorsForMake(string make)
        {
            XDocument inventoryDoc = XDocument.Load("SimpleInventory.xml");
            var makeInfo = from car in inventoryDoc.Descendants("Car")
                           where ((string)car.Element("Make")).ToLower() == make.ToLower()
                           select car.Element("Color").Value;
            string data = "";
            foreach (var item in makeInfo)
            {
                data += string.Format("- {0}\n",item);
            }
            MessageBox.Show(data);
        }
        public static void XMLToDatabase()
        {
            XDocument inventoryDoc=XDocument.Load("SimpleInventory.xml");
            InventoryDAL dal = new InventoryDAL();
            dal.OpenConnection(conString);
            dal.CreateTableInDataBase();
            try
            {
                DataSet ds = new DataSet();
                XmlReader reader = inventoryDoc.CreateReader();
                ds.ReadXml(reader);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                  
                   dal.InsertAuto(Convert.ToInt32(row[0]),(string)(row[1]), (string)row[2], (string)row[3]);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+" Xml to data");
            }
            dal.CloseConnection();
            MessageBox.Show("Data from Xml send to Ole Db successfull");
        }
        public static XDocument GetXMLFromDataBase()
        {
            XDocument invOle = null;
            try
            {

                InventoryDAL dal = new InventoryDAL();
                dal.OpenConnection(conString);
                string sql = "select * from Inventory";
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql,conString);
                DataSet ds = new DataSet();                
                adapter.Fill(ds, "Inventory");
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                  row[1]= ((string)row[1]).Trim(' ');
                    row[2] = ((string)row[2]).Trim(' ');
                    row[3] = ((string)row[3]).Trim(' ');
                }
                ds.WriteXml("InventoryFromOleDb.xml");
                invOle = XDocument.Load("InventoryFromOleDb.xml");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"  adapter");
            }           
            return invOle;
        }
        public static void ChangeColorById(int id,string newColor)
        {
            try
            {

                XDocument inventoryDoc = XDocument.Load("SimpleInventory.xml");
                foreach (XElement elem in inventoryDoc.Descendants("Car"))
                {
                    
                    if ((int)(elem.Element("CarId")) == id)
                    {
                        MessageBox.Show(elem.Element("Color").Value+" changed on "+newColor);
                        elem.Element("Color").Value = newColor;
                    }
                }
                inventoryDoc.Save("SimpleInventory.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+" change color");
            }
        }
        public static void DeleteCarById(int id)
        {

            
            XDocument inventoryDoc = XDocument.Load("SimpleInventory.xml");
            try
            {
                foreach (XElement elem in inventoryDoc.Descendants("Car"))
                {
                    if ((int)(elem.Element("CarId")) == id)
                    {
                        
                        elem.Remove();
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
            inventoryDoc.Save("SimpleInventory.xml");
        }
        public static void ChangeNodeByName(string name)
        {
            XDocument inventoryDoc = XDocument.Load("SimpleInventory.xml");
            try
            {
                foreach (XElement elem in inventoryDoc.Descendants("Car"))
                {
                    MessageBox.Show(name);  
                   // MessageBox.Show();
                    //if ((int)(elem.Element("CarId")) == id)
                    //{

                    //    elem.Remove();
                    //}
                }
            }
            catch (Exception ex)
            {

            }
            inventoryDoc.Save("SimpleInventory.xml");
        }
    }
}
