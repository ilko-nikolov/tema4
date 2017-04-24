using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //memoryCardComboBox.SelectedIndex = wlanComboBox.SelectedIndex = bluetoothComboBox.SelectedIndex = gpsComboBox.SelectedIndex = nfcComboBox.SelectedIndex = radioComboBox.SelectedIndex = 0;
            Controls.OfType<ComboBox>().ToList().ForEach(ComboBox => ComboBox.SelectedIndex = 0);
            errorLabel.Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                //todo: add phone to list
                
            }

        }

        private void requiredAddBox_TextChanged(object sender, EventArgs e)
        {
            TextBox requiredTextBox = sender as TextBox;
            if (requiredTextBox.BackColor == error)
                requiredTextBox.BackColor = Color.White;
            errorLabel.Visible = false;
        }

        private bool isValid()
        {
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

        private void memoryCardComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
