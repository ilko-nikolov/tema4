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
    public partial class Results : UserControl
    {
        public static List<CPhone> resultsList = new List<CPhone>();

        public Results()
        {
            InitializeComponent();
        }

        public void AdvancedSearch()
        {
            listBox1.Items.Clear();
            foreach(CPhone phone in resultsList)
            {
                listBox1.Items.Add(phone.Brand + " " + phone.Model);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CPhone selectedPhone = resultsList.ElementAt(listBox1.SelectedIndex);
            richTextBox1.Text = "Brand: " + selectedPhone.Brand + "\n" +
                "Model: " + selectedPhone.Model + "\n" +
                "Dimensions: " + selectedPhone.Body.Dimensions + "\n" +
                "Weight: " + selectedPhone.Body.Weight + "\n" +
                "SIM: " + selectedPhone.Body.SIM + "\n" +
                "Display Type: " + selectedPhone.Display.Type + "\n" +
                "Display Size: " + selectedPhone.Display.Size + "\n" +
                "Resolution: " + selectedPhone.Display.Resolution + "\n" +
                "Display Protection: " + selectedPhone.Display.Protection + "\n" +
                "Operating System: " + selectedPhone.Platform.OS + "\n" +
                "Chipset: " + selectedPhone.Platform.Chipset + "\n" +
                "CPU: " + selectedPhone.Platform.CPU + "\n" +
                "GPU: " + selectedPhone.Platform.GPU + "\n" +
                "Battery: " + selectedPhone.Battery + "\n" +
                "Internal Memory: " + selectedPhone.Memory.Internal + "\n" +
                "Memory Card: " + selectedPhone.Memory.CardSlot + "\n" +
                "Primary Camera: " + selectedPhone.Camera.Primary + "\n" +
                "Secondary Camera: " + selectedPhone.Camera.Secondary + "\n" +
                "Camera Features: " + selectedPhone.Camera.Features + "\n" +
                "Video: " + selectedPhone.Camera.Video + "\n" +
                "WLAN: " + selectedPhone.Connectivity.WLAN + "\n" +
                "Bluetooth: " + selectedPhone.Connectivity.Bluetooth + "\n" +
                "GPS: " + selectedPhone.Connectivity.GPS + "\n" +
                "NFC: " + selectedPhone.Connectivity.NFC + "\n" +
                "Radio: " + selectedPhone.Connectivity.Radio + "\n" +
                "USB: " + selectedPhone.Connectivity.USB + "\n" +
                "Sensors: " + selectedPhone.Sensors;
        }
    }
}
