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
            throw new NotImplementedException();
        }
        #endregion
    }
}
