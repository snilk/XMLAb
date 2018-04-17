using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LINQToXMLWinApp
{
    class InventoryDAL
    {
        private OleDbConnection oleDBCon = null;
        public void OpenConnection(string connectionString)
        {
            oleDBCon = new OleDbConnection
            {
                ConnectionString = connectionString
            };
            oleDBCon.Open();
        }
        public void CloseConnection()
        {
            oleDBCon.Close();
        }
        public void InsertAuto(int id,string make,string color,string petName)
        {
            string sql = string.Format("Insert into Inventory(CarID, Make, Color, PetName) values('{0}','{1}','{2}','{3}')", id, make, color, petName);
            try
            {
                using (OleDbCommand cmd = new OleDbCommand(sql, this.oleDBCon))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CreateTableInDataBase()
        {
            string dropSql = "DROP TABLE Inventory";
            string sqlCreate= "CREATE TABLE Inventory (CarID INTEGER NOT NULL,Make char(50) NOT NULL,Color char(50) NOT NULL,PetName char(10)) ";
            try
            {
                using (OleDbCommand cmd = new OleDbCommand(dropSql, this.oleDBCon))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong");
            }
            using (OleDbCommand cmd=new OleDbCommand(sqlCreate,this.oleDBCon))
            {
                cmd.ExecuteNonQuery();
            }
    
        }
    }
    
}
