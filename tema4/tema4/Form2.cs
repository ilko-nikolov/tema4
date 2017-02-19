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
    public partial class Form2 : Form
    {
        List<CPhone> phonesList = new List<CPhone>();

        List<int> elements = new List<int>();
        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            brandLbl.Text = modelLbl.Text = osLbl.Text = osVerLbl.Text = memoryLbl.Text = cameraLbl.Text = "";
            //изчистване на label-ите, където ще се появи информацията за намерения телефон
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int elemNumber = 0;
            listBox1.Items.Clear();
            foreach(var phone in phonesList)
            {
                if (phone.brand.Contains(brandTxtBox.Text) &&
                    phone.model.Contains(modelTxtBox.Text) &&
                    phone.os.Contains(osTxtBox.Text) &&
                    phone.osVersion.Contains(osVerTxtBox.Text) &&
                    phone.memory.Contains(memoryTxtBox.Text) &&
                    phone.camera.Contains(cameraTxtBox.Text)
                    )
                {
                    listBox1.Items.Add(phone.brand + " " + phone.model);
                    elements.Add(elemNumber);
                }
                elemNumber++;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CPhone phone = phonesList.ElementAt<CPhone>(elements.ElementAt<int>(listBox1.SelectedIndex));
            brandLbl.Text = "Brand: " + phone.brand;
            modelLbl.Text = "Model: " + phone.model;
            osLbl.Text = "OS: " + phone.os;
            osVerLbl.Text = "OS version: " + phone.osVersion;
            memoryLbl.Text = "Memory: " + phone.memory;
            cameraLbl.Text = "Camera: " + phone.camera;
        }

        private bool loadPhones()
        {
            FileStream fs;
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                fs = new FileStream("data.dat", FileMode.Open);
            }
            catch
            {
                MessageBox.Show("Error, reading file.");
                return false;
            }

            while (fs.Position < fs.Length)
            {
                CPhone obj = (CPhone)bf.Deserialize(fs);
                phonesList.Add(obj);
            }
            fs.Close();
            return true;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            if (!loadPhones()) //чете от файл и записва в List телефоните
            {
                Close(); //затваря формата, ако не е прочетен данновия файл
            }
        }
    }
}


