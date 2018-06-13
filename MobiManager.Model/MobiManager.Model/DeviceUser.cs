using System;

namespace MobiManager.Model
{
    public class DeviceUser
    {
        public Guid DeviceID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public Guid UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
