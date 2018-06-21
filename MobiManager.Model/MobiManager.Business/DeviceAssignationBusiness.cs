using MobiManager.Business.Core;
using MobiManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiManager.Business
{
    public class DeviceAssignationBusiness
    {
		#region Methdos
		public void SetUser(DeviceAssignation device)
		{
			BusinessContext.Current.RepositoryContext.DeviceAssignationRepository.SetUser(device);
		}

		public void RemoveUser(Guid deviceID)
		{
			BusinessContext.Current.RepositoryContext.DeviceAssignationRepository.RemoveUser(deviceID);
		}

		public List<DeviceAssignation> ReadAll()
		{
			return BusinessContext.Current.RepositoryContext.DeviceAssignationRepository.ReadAll();
		}

		public List<DeviceAssignation> GetFreeDevice()
		{
			return BusinessContext.Current.RepositoryContext.DeviceAssignationRepository.GetFreeDevice();
		}

		public DeviceAssignation ReadByID(Guid deviceID)
		{
			return BusinessContext.Current.RepositoryContext.DeviceAssignationRepository.ReadByID(deviceID);
		}
			#endregion
		}
}
