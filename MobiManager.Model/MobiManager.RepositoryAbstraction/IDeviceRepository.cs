using MobiManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiManager.RepositoryAbstraction
{
    public interface IDeviceRepository
    {
        void Insert(Device device);
        void Update(Device device);
        void Delete(Guid deviceID);
        List<Device> ReadAll();
        Device ReadByID(Guid deviceID);
    }
}
