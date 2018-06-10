using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
