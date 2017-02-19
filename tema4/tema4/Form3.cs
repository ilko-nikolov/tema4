using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace tema4
{
    public partial class Form3 : Form
    {
        List<CPhone> phonesList = new List<CPhone>();

        public Form3()
        {
            InitializeComponent();
        }

        private bool validate()
        {
            bool validate=true;

            if (brandTxtBox.Text == "")
            {
                errorProvider1.SetError(brandTxtBox, "Fill the brand");
                validate = false;
            }

            if (modelTxtBox.Text == "")
            {
                errorProvider1.SetError(modelTxtBox, "Fill the model");
                validate = false;
            }

            if (osTxtBox.Text == "")
            {
                errorProvider1.SetError(osTxtBox, "Fill the Operating System");
                validate = false;
            }

            if (osVerTxtBox.Text == "")
            {
                errorProvider1.SetError(osVerTxtBox, "Fill the version of the OS");
                validate = false;
            }

            if (memoryTxtBox.Text == "")
            {
                errorProvider1.SetError(memoryTxtBox, "Fill the size of the memory");
                validate = false;
            }

            if (cameraTxtBox.Text == "")
            {
                errorProvider1.SetError(cameraTxtBox, "Fill info about camera");
                validate = false;
            }

            return validate;
        } //валидация

        private void textBox1_TextChanged(object sender, EventArgs e)
        { //premahva (!), kogato teksta se smeni
            TextBox txtBox = (TextBox) sender;

            if (txtBox.Text != "")
            {
                errorProvider1.SetError(txtBox, "");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (!validate()) { return; } //има празни полета

            CPhone phone = new CPhone();
            phone.brand = brandTxtBox.Text;
            phone.model = modelTxtBox.Text;
            phone.os = osTxtBox.Text;
            phone.osVersion = osVerTxtBox.Text;
            phone.memory = memoryTxtBox.Text;
            phone.camera = cameraTxtBox.Text;

            phonesList.Add(phone);

            XmlSerialization.WriteToXmlFile<List<CPhone>>("data.xml", phonesList);

            brandTxtBox.Text = modelTxtBox.Text = osTxtBox.Text = osVerTxtBox.Text = memoryTxtBox.Text = cameraTxtBox.Text = "";
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try { phonesList = XmlSerialization.ReadFromXmlFile<List<CPhone>>("data.xml"); }
            catch { }
        }
    }
}
