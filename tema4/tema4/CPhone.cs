using System;

namespace gsmarena_scrape
{
    [Serializable]
    public class CPhone
    {
        public class CBody
        {
            public string Dimensions { set; get; }
            public string Weight { set; get; }
            public string SIM { set; get; }
        }
        public class CDisplay
        {
            public string Type { set; get; }
            public string Size { set; get; }
            public string Resolution { set; get; }
            public string Protection { set; get; }
        }
        public class CPlatform
        {
            public string OS { set; get; }
            public string Chipset { set; get; }
            public string CPU { set; get; }
            public string GPU { set; get; }
        }
        public class CMemory
        {
            public string CardSlot { set; get; }
            public string Internal { set; get; }
        }
        public class CCamera
        {
            public string Primary { set; get; }
            public string Features { set; get; }
            public string Video { set; get; }
            public string Secondary { set; get; }
        }
        public class CConnectivity
        {
            public string WLAN { set; get; }
            public string Bluetooth { set; get; }
            public string GPS { set; get; }
            public string NFC { set; get; }
            public string Radio { set; get; }
            public string USB { set; get; }
        }

        public string Brand { set; get; }
        public string Model { set; get; }
        public CBody Body = new CBody();
        public CDisplay Display = new CDisplay();
        public CPlatform Platform = new CPlatform();
        public CMemory Memory = new CMemory();
        public CCamera Camera = new CCamera();
        public CConnectivity Connectivity = new CConnectivity();
        public string Sensors { set; get; }
        public string Battery { set; get; }
    }
}