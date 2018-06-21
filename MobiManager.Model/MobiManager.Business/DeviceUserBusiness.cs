using MobiManager.Business.Core;
using MobiManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiManager.Business
{
    public class DeviceUserBusiness
    {
        #region Methdos
        public List<DeviceUser> DevicesList()
        {
            return BusinessContext.Current.RepositoryContext.DeviceUserRepository.DevicesList();
        }
        #endregion
    }
}
