using gsmarena_scrape;
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

            if (memTxtBox.Text == "")
            {
                errorProvider1.SetError(memTxtBox, "Fill the size of the internal memory");
                validate = false;
            }

            if (pcamTxtBox.Text == "")
            {
                errorProvider1.SetError(pcamTxtBox, "Fill info about primary camera");
                validate = false;
            }

            if (typeTxtBox.Text == "" || sizeTxtBox.Text == "" || resTxtBox.Text == "")
            {
                errorProvider1.SetError(pcamTxtBox, "Fill info about display");
                validate = false;
            }

            if (chipTxtBox.Text == "")
            {
                errorProvider1.SetError(chipTxtBox, "Fill info about chipset");
                validate = false;
            }

            if (cpuTxtBox.Text == "")
            {
                errorProvider1.SetError(pcamTxtBox, "Fill info about CPU");
                validate = false;
            }

            if (gpuTxtBox.Text == "")
            {
                errorProvider1.SetError(pcamTxtBox, "Fill info about GPU");
                validate = false;
            }

            if (batTxtBox.Text == "")
            {
                errorProvider1.SetError(pcamTxtBox, "Fill info about battery");
                validate = false;
            }

            if (senTxtBox.Text == "")
            {
                errorProvider1.SetError(pcamTxtBox, "Fill info about sensors");
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
            phone.Brand = brandTxtBox.Text;
            phone.Model = modelTxtBox.Text;
            phone.Body.Dimensions = dimTxtBox.Text;
            phone.Body.Weight = wgTxtBox.Text;
            phone.Body.SIM = simTxtBox.Text;
            phone.Display.Type = typeTxtBox.Text;
            phone.Display.Size = sizeTxtBox.Text;
            phone.Display.Resolution = resTxtBox.Text;
            phone.Display.Protection = proTxtBox.Text;
            phone.Platform.OS = osTxtBox.Text;
            phone.Platform.Chipset = chipTxtBox.Text;
            phone.Platform.CPU = cpuTxtBox.Text;
            phone.Platform.GPU = gpuTxtBox.Text;
            phone.Memory.Internal = memTxtBox.Text;
            phone.Memory.CardSlot = sdTxtBox.Text;
            phone.Camera.Primary = pcamTxtBox.Text;
            phone.Camera.Features = featTxtBox.Text;
            phone.Camera.Video = vidTxtBox.Text;
            phone.Camera.Secondary = scamTxtBox.Text;
            phone.Connectivity.WLAN = wlanTxtBox.Text;
            phone.Connectivity.Bluetooth = bluTxtBox.Text;
            phone.Connectivity.GPS = gpsTxtBox.Text;
            phone.Connectivity.NFC = nfcTxtBox.Text;
            phone.Connectivity.Radio = radTxtBox.Text;
            phone.Connectivity.USB = usbTxtBox.Text;
            phone.Battery = batTxtBox.Text;
            phone.Sensors = senTxtBox.Text;
            phonesList.Add(phone);

            XmlSerialization.WriteToXmlFile<List<CPhone>>("data.xml", phonesList);

            brandTxtBox.Text = modelTxtBox.Text = dimTxtBox.Text = wgTxtBox.Text = simTxtBox.Text 
            = typeTxtBox.Text = sizeTxtBox.Text = resTxtBox.Text = proTxtBox.Text = osTxtBox.Text 
            = chipTxtBox.Text = cpuTxtBox.Text = gpuTxtBox.Text = memTxtBox.Text = sdTxtBox.Text 
            = pcamTxtBox.Text = featTxtBox.Text = vidTxtBox.Text = scamTxtBox.Text = wlanTxtBox.Text 
            = bluTxtBox.Text = gpsTxtBox.Text = nfcTxtBox.Text = radTxtBox.Text = usbTxtBox.Text = 
            batTxtBox.Text = senTxtBox.Text = "";
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try { phonesList = XmlSerialization.ReadFromXmlFile<List<CPhone>>("data.xml"); }
            catch { }
        }
    }
}
