using MobiManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiManager.RepositoryAbstraction
{
    public interface IDeviceAssignationRepository
    {
        void SetUser(DeviceAssignation device);
        void RemoveUser(Guid deviceID);
        List<DeviceAssignation> ReadAll();
        List<DeviceAssignation> GetFreeDevice();
        DeviceAssignation ReadByID(Guid deviceID);
    }
}
