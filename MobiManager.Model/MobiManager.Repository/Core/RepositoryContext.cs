using System;

namespace MobiManager.Repository.Core
{
    public class RepositoryContext : IDisposable
    {
        #region Members
        private static readonly RepositoryContext _instance = new RepositoryContext();
        private UserRepository _userRepository;
        private DeviceUserRepository _deviceUserRepository;
        private DeviceRepository _deviceRepository;
        private DeviceAssignationRepository _deviceAssignationRepository;

        #endregion

        #region Constructor
        public RepositoryContext() {}
        #endregion

        #region Properties
        public static RepositoryContext Current
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

        public UserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository();
                return _userRepository;
            }
        }

        public DeviceUserRepository DeviceUserRepository
        {
            get
            {
                if (_deviceUserRepository == null)
                    _deviceUserRepository = new DeviceUserRepository();
                return _deviceUserRepository;
            }
        }

        public DeviceRepository DeviceRepository
        {
            get
            {
                if (_deviceRepository == null)
                    _deviceRepository = new DeviceRepository();
                return _deviceRepository;
            }
        }

        public DeviceAssignationRepository DeviceAssignationRepository
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
