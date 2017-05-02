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
    public partial class AdvancedSearch : UserControl
    {
        public delegate void customHandler();
        public event customHandler ShowResults;

        private List<CPhone> advancedSearchList = new List<CPhone>();

        public AdvancedSearch()
        {
            InitializeComponent();
        }

        private void Find(string sender)
        {
            int elemNumber = 0;
            advancedSearchList.Clear();

            foreach (var phone in CPhone.phonesList)
            {
                if (phone.Brand.ToLower().Contains(brandSearchBox.Text.ToLower()) &&
                    phone.Model.Contains(modelSearchBox.Text) &&
                    phone.Body.Dimensions.Contains(dimensionsSearchBox.Text) &&
                    phone.Body.Weight.Contains(weightSearchBox.Text) &&
                    phone.Body.SIM.Contains(simSearchBox.Text) &&
                    phone.Display.Type.Contains(displayTypeSearchBox.Text) &&
                    phone.Display.Size.Contains(displaySizeSearchBox.Text) &&
                    phone.Display.Resolution.Contains(resolutionSearchBox.Text) &&
                    phone.Display.Protection.Contains(displayProtectionSearchBox.Text) &&
                    phone.Platform.OS.Contains(osSearchBox.Text) &&
                    phone.Platform.Chipset.Contains(chipsetSearchBox.Text) &&
                    phone.Platform.CPU.Contains(cpuSearchBox.Text) &&
                    phone.Platform.GPU.Contains(gpuSearchBox.Text) &&
                    phone.Memory.Internal.Contains(internalMemorySearchBox.Text) &&
                    ((phone.Memory.CardSlot[0] == 'Y' && memoryCardCheckBox.Checked) || !memoryCardCheckBox.Checked) &&
                    phone.Camera.Primary.Contains(primaryCameraSearchBox.Text) &&
                    phone.Camera.Features.Contains(cameraFeaturesSearchBox.Text) &&
                    phone.Camera.Video.Contains(videoSearchBox.Text) &&
                    phone.Camera.Secondary.Contains(secondayCameraSearchBox.Text) &&
                    ((phone.Connectivity.WLAN[0] == 'Y' && wlanCheckBox.Checked) || !wlanCheckBox.Checked) &&
                    ((phone.Connectivity.Bluetooth[0] == 'Y' && bluetoothCheckBox.Checked) || !bluetoothCheckBox.Checked) &&
                    ((phone.Connectivity.GPS[0] == 'Y' && gpsCheckBox.Checked) || !gpsCheckBox.Checked) &&
                    ((phone.Connectivity.NFC[0] == 'Y' && nfcCheckBox.Checked) || !nfcCheckBox.Checked) &&
                    ((phone.Connectivity.Radio[0] == 'Y' && radioCheckBox.Checked) || !radioCheckBox.Checked) &&
                    phone.Connectivity.USB.Contains(usbSearchBox.Text) &&
                    phone.Battery.Contains(batterySearchBox.Text) &&
                    phone.Sensors.Contains(sensorsSearchBox.Text)
                    )
                {
                    elemNumber++;

                    if (sender=="searchButton")
                    {
                        advancedSearchList.Add(phone);
                    }                    
                }
            }
            if (sender == "searchButton")
            {
                Results.resultsList = new List<CPhone>(advancedSearchList);
                ShowResults();
                return;
            }
            searchButton.Text = "SHOW\nResults: " + elemNumber;
            if (elemNumber == CPhone.phonesList.Count)
                searchButton.Text = "SHOW\nAll";
        }

        private void Criteria_Changed(object sender, EventArgs e)
        {
            Find("textbox");   
        }

        private void AdvancedSearch_Load(object sender, EventArgs e)
        {
            Criteria_Changed(null, null);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Find("searchButton");
        }
    }
}
