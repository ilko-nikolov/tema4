using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace tema4
{
    public partial class Add : UserControl
    {
        Color error = new Color();
        //MainForm main = new MainForm();

        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        { 
            error = Color.FromArgb(255, 150, 150);
            
            Controls.OfType<ComboBox>().ToList().ForEach(ComboBox => ComboBox.SelectedIndex = 0);
            errorLabel.Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                //todo: add phone to list

                CPhone newPhone = new CPhone();

                newPhone.Brand = brandAddBox.Text;
                newPhone.Model = modelAddBox.Text;
                newPhone.Body.Dimensions = dimensionsAddBox.Text;
                newPhone.Body.Weight = weightAddBox.Text;
                newPhone.Body.SIM = simAddBox.Text;
                newPhone.Display.Type = displayTypeAddBox.Text;
                newPhone.Display.Size = displaySizeAddBox.Text;
                newPhone.Display.Resolution = resolutionAddBox.Text;
                newPhone.Display.Protection = displayProtectionAddBox.Text;
                newPhone.Platform.OS = operatingSystemAddBox.Text;
                newPhone.Platform.Chipset = chipsetAddBox.Text;
                newPhone.Platform.CPU = cpuAddBox.Text;
                newPhone.Platform.GPU = gpsAddBox.Text;
                newPhone.Battery = batteryAddBox.Text;
                newPhone.Memory.Internal = internalMemoryAddBox.Text;
                newPhone.Memory.CardSlot = memoryCardComboBox.Text;
                newPhone.Memory.CardSlot += (memoryCardAddBox.Text != "") ? " - " + memoryCardAddBox : null;
                newPhone.Camera.Primary = primaryCameraAddBox.Text;
                newPhone.Camera.Secondary = secondaryCameraAddBox.Text;
                newPhone.Camera.Features = cameraFeaturesAddBox.Text;
                newPhone.Camera.Video = videoAddBox.Text;
                newPhone.Connectivity.WLAN = wlanComboBox.Text;
                newPhone.Connectivity.WLAN += (wlanAddBox.Text != "") ? " - " + wlanAddBox.Text : null;
                newPhone.Connectivity.Bluetooth = bluetoothComboBox.Text;
                newPhone.Connectivity.Bluetooth += (bluetoothAddBox.Text != "") ? " - " + bluetoothAddBox.Text : null;
                newPhone.Connectivity.GPS = gpsComboBox.Text;
                newPhone.Connectivity.GPS += (bluetoothAddBox.Text != "") ? " - " + bluetoothAddBox.Text : null;
                newPhone.Connectivity.NFC = nfcComboBox.Text;
                newPhone.Connectivity.NFC += (nfcAddBox.Text != "") ? " - " + nfcAddBox.Text : null;
                newPhone.Connectivity.Radio = radioComboBox.Text;
                newPhone.Connectivity.Radio += (radioAddBox.Text != "") ? " - " + radioAddBox.Text : null;
                newPhone.Connectivity.USB = usbAddBox.Text;
                newPhone.Sensors = sensorsAddBox.Text;

                CPhone.phonesList.Add(newPhone);

                XmlSerialization.WriteToXmlFile<List<CPhone>>("data.xml", CPhone.phonesList);

                resetButton_Click(null, null);
            }

        }

        private void requiredAddBox_TextChanged(object sender, EventArgs e)
        {   //
            TextBox requiredTextBox = sender as TextBox;
            if (requiredTextBox.BackColor == error)
                requiredTextBox.BackColor = Color.White;
            errorLabel.Visible = false;
        }

        private bool isValid()
        { //validation
            bool status = true;
            if (brandAddBox.Text == "") { brandAddBox.BackColor = error; status = false; }
            if (modelAddBox.Text == "") { modelAddBox.BackColor = error; status = false; }
            if (resolutionAddBox.Text == "") { resolutionAddBox.BackColor = error; status = false; }
            if (operatingSystemAddBox.Text == "") { operatingSystemAddBox.BackColor = error; status = false; }
            if (primaryCameraAddBox.Text == "") { primaryCameraAddBox.BackColor = error; status = false; }
            if (secondaryCameraAddBox.Text == "") { secondaryCameraAddBox.BackColor = error; status = false; }
            if (!status)
                errorLabel.Visible = true;
            return status;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if(comboBox == memoryCardComboBox)
                memoryCardAddBox.Enabled = (comboBox.SelectedIndex == 0) ? true : false;
            else if (comboBox == wlanComboBox)
                wlanAddBox.Enabled = (comboBox.SelectedIndex == 0) ? true : false;
            else if (comboBox == bluetoothComboBox)
                bluetoothAddBox.Enabled = (comboBox.SelectedIndex == 0) ? true : false;
            else if (comboBox == gpsComboBox)
                gpsAddBox.Enabled = (comboBox.SelectedIndex == 0) ? true : false;
            else if (comboBox == nfcComboBox)
                nfcAddBox.Enabled = (comboBox.SelectedIndex == 0) ? true : false;
            else if (comboBox == radioComboBox)
                radioAddBox.Enabled = (comboBox.SelectedIndex == 0) ? true : false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Controls.OfType<TextBox>().ToList().ForEach(TextBox => TextBox.Text = "");
            Controls.OfType<TextBox>().ToList().ForEach(TextBox => TextBox.BackColor = Color.White);
            Controls.OfType<ComboBox>().ToList().ForEach(ComboBox => ComboBox.SelectedIndex = 0);
            errorLabel.Visible = false;
        }
    }
}
