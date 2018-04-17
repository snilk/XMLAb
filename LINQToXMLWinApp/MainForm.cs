using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQToXMLWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           LinqToXMLObjectModel l = new LinqToXMLObjectModel();
           txtInventory.Text = LinqToXMLObjectModel.GetXMLInventory().ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            LinqToXMLObjectModel.InsertNewElement(txtMake.Text, txtColor.Text, txtPetName.Text);
            txtInventory.Text = LinqToXMLObjectModel.GetXMLInventory().ToString();
        }

        private void btnLookUpColors_Click(object sender, EventArgs e)
        {
            LinqToXMLObjectModel.LookUpColorsForMake(txtMakeColor.Text);
            txtInventory.Text = LinqToXMLObjectModel.GetXMLInventory().ToString();
        }

        private void btnXmlToBase_Click(object sender, EventArgs e)
        {
            LinqToXMLObjectModel.XMLToDatabase();
        }

        private void btnBaseToXml_Click(object sender, EventArgs e)
        {
            txtInventory.Text = LinqToXMLObjectModel.GetXMLFromDataBase().ToString();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            LinqToXMLObjectModel.ChangeColorById(Convert.ToInt32(txtBoxChangeId.Text),txtBoxChangedColor.Text.ToString());
            txtInventory.Text = LinqToXMLObjectModel.GetXMLInventory().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinqToXMLObjectModel.DeleteCarById(Convert.ToInt32(txtBoxDeleteCarById.Text));
            txtInventory.Text = LinqToXMLObjectModel.GetXMLInventory().ToString();
        }

        private void btnChangeNode_Click(object sender, EventArgs e)
        {
            LinqToXMLObjectModel.ChangeNodeByName(txtBoxOldNode.Text.ToString());
        }
    }
}
