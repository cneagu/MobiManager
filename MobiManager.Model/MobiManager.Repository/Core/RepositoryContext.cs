using MobiManager.RepositoryAbstraction;
using MobiManager.RepositoryAbstraction.Core;
using System;

namespace MobiManager.Repository.Core
{
    public class RepositoryContext : IRepositoryContext
    {
        #region Members
        private static IRepositoryContext _instance;
        private IUserRepository _userRepository;
        private IDeviceUserRepository _deviceUserRepository;
        private IDeviceRepository _deviceRepository;
        private IDeviceAssignationRepository _deviceAssignationRepository;
        #endregion

        #region Constructor
        public RepositoryContext()
        {
            _instance = this;
        }
        #endregion

        #region Properties
        internal static IRepositoryContext Current
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
        
        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository();
                return _userRepository;
            }
        }

        public IDeviceUserRepository DeviceUserRepository
        {
            get
            {
                if (_deviceUserRepository == null)
                    _deviceUserRepository = new DeviceUserRepository();
                return _deviceUserRepository;
            }
        }

        public IDeviceRepository DeviceRepository
        {
            get
            {
                if (_deviceRepository == null)
                    _deviceRepository = new DeviceRepository();
                return _deviceRepository;
            }
        }

        public IDeviceAssignationRepository DeviceAssignationRepository
        {
            get
            {
                if (_deviceAssignationRepository == null)
                    _deviceAssignationRepository = new DeviceAssignationRepository();
                return _deviceAssignationRepository;
            }
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
                if (_userRepository != null)
                {
                    _userRepository = null;
                }
                if (_deviceUserRepository != null)
                {
                    _deviceUserRepository = null;
                }
                if (_deviceRepository != null)
                {
                    _deviceRepository = null;
                }
                if (_deviceAssignationRepository != null)
                {
                    _deviceAssignationRepository = null;
                }
            }
        }

        ~RepositoryContext()
        {
            Dispose(false);
        }
        #endregion
    }
}