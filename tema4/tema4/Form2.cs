using tema4;
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
            //brandLbl.Text = modelLbl.Text = osLbl.Text = osVerLbl.Text = memoryLbl.Text = pcamLbl.Text = "";
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
                if (phone.Brand.Contains(brandTxtBox.Text) &&
                    phone.Model.Contains(modelTxtBox.Text) &&
                    phone.Body.Dimensions.Contains(dimTxtBox.Text) &&
                    phone.Body.Weight.Contains(wgTxtBox.Text) &&
                    phone.Body.SIM.Contains(simTxtBox.Text) &&
                    phone.Display.Type.Contains(typeTxtBox.Text) &&
                    phone.Display.Size.Contains(sizeTxtBox.Text) &&
                    phone.Display.Resolution.Contains(resTxtBox.Text) &&
                    phone.Display.Protection.Contains(proTxtBox.Text) &&
                    phone.Platform.OS.Contains(osTxtBox.Text) &&
                    phone.Platform.Chipset.Contains(chipTxtBox.Text) &&
                    phone.Platform.CPU.Contains(cpuTxtBox.Text) &&
                    phone.Platform.GPU.Contains(gpuTxtBox.Text) &&
                    phone.Memory.Internal.Contains(memTxtBox.Text) &&
                    phone.Memory.CardSlot.Contains(sdTxtBox.Text) &&
                    phone.Camera.Primary.Contains(pcamTxtBox.Text) &&
                    phone.Camera.Features.Contains(featTxtBox.Text) &&
                    phone.Camera.Video.Contains(vidTxtBox.Text) &&
                    phone.Camera.Secondary.Contains(scamTxtBox.Text) &&
                    phone.Connectivity.WLAN.Contains(wlanTxtBox.Text) &&
                    phone.Connectivity.Bluetooth.Contains(bluTxtBox.Text) &&
                    phone.Connectivity.GPS.Contains(gpsTxtBox.Text) &&
                    phone.Connectivity.NFC.Contains(nfcTxtBox.Text) &&
                    phone.Connectivity.Radio.Contains(radTxtBox.Text) &&
                    phone.Connectivity.USB.Contains(usbTxtBox.Text) &&
                    phone.Battery.Contains(batTxtBox.Text) &&
                    phone.Sensors.Contains(senTxtBox.Text)
                    )
                {
                    listBox1.Items.Add(phone.Brand + " " + phone.Model);
                    elements.Add(elemNumber);
                }
                elemNumber++;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CPhone phone = phonesList.ElementAt<CPhone>(elements.ElementAt<int>(listBox1.SelectedIndex));
            brandLbl.Text = "Brand: " + phone.Brand;
            modelLbl.Text = "Model: " + phone.Model;
            dimLbl.Text = "Brand: " + phone.Body.Dimensions;
            wgLbl.Text = "Model: " + phone.Body.Weight;
            simLbl.Text = "Brand: " + phone.Body.SIM;
            typeLbl.Text = "Model: " + phone.Display.Type;
            sizeLbl.Text = "Model: " + phone.Display.Size;
            resLbl.Text = "Brand: " + phone.Display.Resolution;
            proLbl.Text = "Model: " + phone.Display.Protection;
            osLbl.Text = "OS: " + phone.Platform.OS;
            chipLbl.Text = "Model: " + phone.Platform.Chipset;
            cpuLbl.Text = "Brand: " + phone.Platform.GPU;
            gpuLbl.Text = "Model: " + phone.Platform.GPU;
            memLbl.Text = "Memory: " + phone.Memory.Internal;
            sdLbl.Text = "Model: " + phone.Memory.CardSlot;
            pcamLbl.Text = "Brand: " + phone.Camera.Primary;
            scamLbl.Text = "Model: " + phone.Camera.Secondary;
            featLbl.Text = "Model: " + phone.Camera.Features;
            vidLbl.Text = "Brand: " + phone.Camera.Video;
            wlanLbl.Text = "Model: " + phone.Connectivity.WLAN;
            bluLbl.Text = "Model: " + phone.Connectivity.Bluetooth;
            gpsLbl.Text = "Brand: " + phone.Connectivity.GPS;
            nfcLbl.Text = "Model: " + phone.Connectivity.NFC;
            radLbl.Text = "Model: " + phone.Connectivity.Radio;
            usbLbl.Text = "Brand: " + phone.Connectivity.USB;
            batLbl.Text = "Model: " + phone.Battery;
            senLbl.Text = "Camera: " + phone.Sensors;
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


