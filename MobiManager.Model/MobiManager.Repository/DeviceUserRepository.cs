using MobiManager.Model;
using MobiManager.Repository.Core;
using MobiManager.RepositoryAbstraction;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MobiManager.Repository
{
    public class DeviceUserRepository : BaseRepository<DeviceUser>, IDeviceUserRepository
    {
        #region Methdos
        public List<DeviceUser> DevicesList()
        {
            return Read("dbo.DevicesList");
        }

        protected override DeviceUser GetModelFromReader(SqlDataReader reader)
        {
            DeviceUser device = new DeviceUser();
            device.DeviceID = reader.GetGuid(reader.GetOrdinal("DeviceID"));
            device.Name = reader.GetString(reader.GetOrdinal("Name"));
            device.Manufacturer = reader.GetString(reader.GetOrdinal("Manufacturer"));
            device.UserID = reader.IsDBNull(3) != true ? reader.GetGuid(reader.GetOrdinal("UserID")) : Guid.Empty ;
            device.FirstName = reader.IsDBNull(4) != true ? reader.GetString(reader.GetOrdinal("FirstName")) : String.Empty;
            device.LastName = reader.IsDBNull(5) != true ? reader.GetString(reader.GetOrdinal("LastName")) : String.Empty;
            return (device);
        }
        #endregion
    }
}
