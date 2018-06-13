using System;

namespace MobiManager.Model
{   //Device Class
    public class Device
    {
        public Guid DeviceID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public bool Type { get; set; }
        public string OperatingSystem { get; set; }
        public string OSVersion { get; set; }
        public string Processor { get; set; }
        public string RAMAmount { get; set; }
    }
}
