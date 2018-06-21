using MobiManager.Business.Core;
using MobiManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiManager.Business
{
    public class DeviceBusiness
    {
		#region Methdos
		public void Insert(Device device)
		{
			BusinessContext.Current.RepositoryContext.DeviceRepository.Insert(device);
		}

		public void Update(Device device)
		{
			BusinessContext.Current.RepositoryContext.DeviceRepository.Update(device);
		}

		public void Delete(Guid deviceID)
		{
			BusinessContext.Current.RepositoryContext.DeviceRepository.Delete(deviceID);
		}

		public List<Device> ReadAll()
		{
			return BusinessContext.Current.RepositoryContext.DeviceRepository.ReadAll();
		}

		public Device ReadByID(Guid deviceID)
		{
			return BusinessContext.Current.RepositoryContext.DeviceRepository.ReadByID(deviceID);
		}
			#endregion
		}
}
