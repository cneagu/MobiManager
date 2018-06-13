using MobiManager.Model;
using MobiManager.Repository.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MobiManager.Repository
{
    public class DeviceRepository : BaseRepository<Device>
    {
        #region Methdos
        public void Insert(Device device)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@DeviceID", device.DeviceID),
                new SqlParameter("@Name", device.Name),
                new SqlParameter("@Manufacturer", device.Manufacturer),
                new SqlParameter("@Type", device.Type),
                new SqlParameter("@OperatingSystem", device.OperatingSystem),
                new SqlParameter("@OSVersion", device.OSVersion),
                new SqlParameter("@Processor", device.Processor),
                new SqlParameter("@RAMAmount", device.RAMAmount) };
            ExecuteNonQuery("dbo.Devices_Insert", parameters);
        }

        public void Update(Device device)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@DeviceID", device.DeviceID),
                new SqlParameter("@Name", device.Name),
                new SqlParameter("@Manufacturer", device.Manufacturer),
                new SqlParameter("@Type", device.Type),
                new SqlParameter("@OperatingSystem", device.OperatingSystem),
                new SqlParameter("@OSVersion", device.OSVersion),
                new SqlParameter("@Processor", device.Processor),
                new SqlParameter("@RAMAmount", device.RAMAmount) };
            ExecuteNonQuery("dbo.Devices_UpdateByID", parameters);
        }

        public void Delete(Guid deviceID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@DeviceID", deviceID) };
            ExecuteNonQuery("dbo.Devices_DeleteByID", parameters);
        }

        public List<Device> ReadAll()
        {
            return Read("dbo.Devices_ReadAll");
        }

        public Device ReadByID(Guid deviceID)
        {
            List<Device> result = new List<Device>();
            SqlParameter[] parameters = { new SqlParameter("@DeviceID", deviceID) };
            result = Read("dbo.Devices_ReadByID", parameters);
            if (result.Count > 0)
            {
                return result[0];
            }
            else
                return new Device();
        }

        protected override Device GetModelFromReader(SqlDataReader reader)
        {
            Device device = new Device();
            device.DeviceID = reader.GetGuid(reader.GetOrdinal("DeviceID"));
            device.Name = reader.GetString(reader.GetOrdinal("Name"));
            device.Manufacturer = reader.GetString(reader.GetOrdinal("Manufacturer"));
            device.Type = reader.GetBoolean(reader.GetOrdinal("Type"));
            device.OperatingSystem = reader.GetString(reader.GetOrdinal("OperatingSystem"));
            device.OSVersion = reader.GetString(reader.GetOrdinal("OSVersion"));
            device.Processor = reader.GetString(reader.GetOrdinal("Processor"));
            device.RAMAmount = reader.GetInt32(reader.GetOrdinal("RAMAmount"));
            return (device);
        }
        #endregion
    }
}
