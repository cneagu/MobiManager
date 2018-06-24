using MobiManager.Model;
using MobiManager.Repository.Core;
using MobiManager.RepositoryAbstraction;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MobiManager.Repository
{
    public class DeviceAssignationRepository : BaseRepository<DeviceAssignation>, IDeviceAssignationRepository
    {
        #region Methdos
        public void SetUser(DeviceAssignation device)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@DeviceID", device.DeviceID),
                new SqlParameter("@UserID", device.UserID) };
            ExecuteNonQuery("dbo.DevicesAssignation_SetUser", parameters);
        }

        public void RemoveUser(Guid deviceID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@DeviceID", deviceID) };
            ExecuteNonQuery("dbo.DevicesAssignation_RemoveUser", parameters);
        }

        public List<DeviceAssignation> ReadAll()
        {
            return Read("dbo.DevicesAssignation_ReadAll");
        }

        public List<DeviceAssignation> GetFreeDevice()
        {
            return Read("dbo.DevicesAssignation_FreeDevices");
        }

        public List<DeviceAssignation> ReadByID(Guid UserID)
        {
            List<DeviceAssignation> result = new List<DeviceAssignation>();
            SqlParameter[] parameters = { new SqlParameter("@UserID", UserID) };
            result = Read("dbo.DevicesAssignation_ReadByID", parameters);
            if (result.Count > 0)
            {
                return result;
            }
            else
                return new List<DeviceAssignation>();
        }

        protected override DeviceAssignation GetModelFromReader(SqlDataReader reader)
        {
            DeviceAssignation device = new DeviceAssignation();
            device.DeviceID = reader.GetGuid(reader.GetOrdinal("DeviceID"));
            device.UserID = reader.IsDBNull(1) != true ? reader.GetGuid(reader.GetOrdinal("UserID")) : Guid.Empty;
            return (device);
        }
        #endregion
    }
}
