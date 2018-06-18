using MobiManager.Business.Core;
using MobiManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiManager.Business
{
    public class UserBusiness
    {
        #region Methdos
        public void Insert(User user)
        {
            BusinessContext.Current.RepositoryContext.UserRepository.Insert(user);
        }

        public void Update(User user)
        {
            BusinessContext.Current.RepositoryContext.UserRepository.Update(user);
        }

        public void Delete(Guid userID)
        {
            BusinessContext.Current.RepositoryContext.UserRepository.Delete(userID);
        }

        public List<User> ReadAll()
        {
            return BusinessContext.Current.RepositoryContext.UserRepository.ReadAll();
        }

        public User ReadByID(Guid userID)
        {
            return BusinessContext.Current.RepositoryContext.UserRepository.ReadByID(userID);
        }

        public string ReadUserName(string userName)
        {
            return BusinessContext.Current.RepositoryContext.UserRepository.ReadUserName(userName);
        }
        #endregion
    }
}
