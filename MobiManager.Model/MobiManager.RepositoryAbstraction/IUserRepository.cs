using MobiManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiManager.RepositoryAbstraction
{
    public interface IUserRepository
    {
        void Insert(User user);
        void Update(User user);
        void Delete(Guid userID);
        List<User> ReadAll();
        User ReadByID(Guid userID);
        User ReadUserName(string userName);
        Guid ReadLogIn(string userName, string password);
    }
}
