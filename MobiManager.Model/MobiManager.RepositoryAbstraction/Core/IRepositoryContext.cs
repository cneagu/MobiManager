using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiManager.RepositoryAbstraction.Core
{
    public interface IRepositoryContext : IDisposable
    {
        IDeviceAssignationRepository DeviceAssignationRepository { get; }
        IDeviceRepository DeviceRepository { get; }
        IDeviceUserRepository DeviceUserRepository { get; }
        IUserRepository UserRepository { get; }
    }
}
