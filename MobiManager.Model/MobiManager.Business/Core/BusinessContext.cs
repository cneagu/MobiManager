using MobiManager.RepositoryAbstraction.Core;
using MobiManager.RepositoryFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiManager.Business.Core
{
    public class BusinessContext : IDisposable
    {
        #region Members
        private static BusinessContext _instance;
        private IRepositoryContext _repositoryContext;
        private DeviceAssignationBusiness _deviceAssignationBusiness;
        private DeviceBusiness _deviceBusiness;
        private DeviceUserBusiness _deviceUserBusiness;
        private UserBusiness _dserBusiness;
        #endregion
        #region Constructor
        public BusinessContext()
        {
            _instance = this;
            _repositoryContext = Getter.GetRepository();
        }
        #endregion

        #region Properties
        internal static BusinessContext Current
        {
            get
            {
                if (_instance == null)
                {
                    throw new Exception("No RepositoryContext instance available!");
                }
                return _instance;
            }
        }

        public DeviceAssignationBusiness DeviceAssignationBusiness
        {
            get
            {
                if (_deviceAssignationBusiness == null)
                    _deviceAssignationBusiness = new DeviceAssignationBusiness();
                return _deviceAssignationBusiness;
            }
        }

        public DeviceBusiness DeviceBusiness
        {
            get
            {
                if (_deviceBusiness == null)
                    _deviceBusiness = new DeviceBusiness();
                return _deviceBusiness;
            }
        }

        public DeviceUserBusiness DeviceUserBusiness
        {
            get
            {
                if (_deviceUserBusiness == null)
                    _deviceUserBusiness = new DeviceUserBusiness();
                return _deviceUserBusiness;
            }
        }

        public UserBusiness UserBusiness
        {
            get
            {
                if (_dserBusiness == null)
                    _dserBusiness = new UserBusiness();
                return _dserBusiness;
            }
        }

        internal IRepositoryContext RepositoryContext
        {
            get { return _repositoryContext; }
        }
        #endregion

        #region IDisposable Implementation
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool dispose)
        {
            if (dispose)
            {
                if (_deviceAssignationBusiness != null)
                {
                    _deviceAssignationBusiness = null;
                }
                if (_deviceBusiness != null)
                {
                    _deviceBusiness = null;
                }
                if (_deviceUserBusiness != null)
                {
                    _deviceUserBusiness = null;
                }
                if (_dserBusiness != null)
                {
                    _dserBusiness = null;
                }
            }
        }

        ~BusinessContext()
        {
            Dispose(false);
        }
        #endregion
    }
}
