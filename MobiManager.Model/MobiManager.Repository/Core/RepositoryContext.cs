using System;

namespace MobiManager.Repository.Core
{
    public class RepositoryContext : IDisposable
    {
        #region Members
        private static readonly RepositoryContext _instance = new RepositoryContext();
        private UserRepository _userRepository;

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

            }
        }

        ~RepositoryContext()
        {
            Dispose(false);
        }
        #endregion
    }
}
