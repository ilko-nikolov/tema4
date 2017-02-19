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

            //loadPhones();
            try { phonesList = XmlSerialization.ReadFromXmlFile<List<CPhone>>("data.xml"); }
            catch { MessageBox.Show("Error when reading data file"); }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int elemNumber = 0; elements.Clear();
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

        //private void loadPhones()
        //{
        //    BinaryReader br;
        //    FileStream fs;

        //    CPhone phone = new CPhone();

        //    try
        //    {
        //        fs = new FileStream("data.dat", FileMode.Open);
        //        br = new BinaryReader(fs);
        //    }
        //    catch (IOException err)
        //    {
        //        MessageBox.Show(err.Message + " Cannot open file.");
        //        return;
        //    }

        //    while (br.PeekChar() != -1)
        //    {
        //        try
        //        {
        //            phone.brand = br.ReadString();
        //            phone.model = br.ReadString();
        //            phone.os = br.ReadString();
        //            phone.osVersion = br.ReadString();
        //            phone.memory = br.ReadString();
        //            phone.camera = br.ReadString();
        //        }
        //        catch (IOException err)
        //        {
        //            MessageBox.Show(err.Message + " Cannot read from file");
        //        }
        //        phonesList.Add(phone);
        //    }
        //}
    }
}


