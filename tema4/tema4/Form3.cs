using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tema4
{
    public partial class Form3 : Form
    {
 
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


            FileStream fs;
            try { fs = new FileStream("data.dat", FileMode.OpenOrCreate); }
            catch { MessageBox.Show("Error when creating or opening file."); return; }

            BinaryFormatter bf = new BinaryFormatter();

            CPhone phone = new CPhone();

            phone.brand = brandTxtBox.Text;
            phone.model = modelTxtBox.Text;
            phone.os = osTxtBox.Text;
            phone.osVersion = osVerTxtBox.Text;
            phone.memory = memoryTxtBox.Text;
            phone.camera = cameraTxtBox.Text;

            bf.Serialize(fs, phone);
            fs.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
