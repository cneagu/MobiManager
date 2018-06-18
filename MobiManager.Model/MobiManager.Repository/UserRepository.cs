using MobiManager.Model;
using MobiManager.Repository.Core;
using MobiManager.RepositoryAbstraction;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MobiManager.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        #region Methdos
        public void Insert(User user)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@UserID", user.UserID),
                new SqlParameter("@FirstName", user.FirstName),
                new SqlParameter("@LastName", user.LastName),
                new SqlParameter("@UserName", user.UserName),
                new SqlParameter("@Password", user.Password),
                new SqlParameter("@Role", user.Role),
                new SqlParameter("@Location", user.Location) };
            ExecuteNonQuery("dbo.Users_Insert", parameters);
        }

        public void Update(User user)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@UserID", user.UserID),
                new SqlParameter("@FirstName", user.FirstName),
                new SqlParameter("@LastName", user.LastName),
                new SqlParameter("@UserName", user.UserName),
                new SqlParameter("@Password", user.Password),
                new SqlParameter("@Role", user.Role),
                new SqlParameter("@Location", user.Location) };
            ExecuteNonQuery("dbo.Users_UpdateByID", parameters);
        }

        public void Delete(Guid userID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@UserID", userID) };
            ExecuteNonQuery("dbo.Users_DeleteByID", parameters);
        }

        public List<User> ReadAll()
        {
            return Read("dbo.Users_ReadAll");
        }

        public User ReadByID(Guid userID)
        {
            List<User> result = new List<User>();
            SqlParameter[] parameters = { new SqlParameter("@UserID", userID) };
            result = Read("dbo.Users_ReadByID", parameters);
            if (result.Count > 0)
            {
                return result[0];
            }
            else
                return new User();
        }

        public string ReadUserName(string userName)
        {
            List<User> result = new List<User>();
            SqlParameter[] parameters = { new SqlParameter("@UserName", userName) };
            result = Read("dbo.Users_ReadUserName", parameters);
            if (result.Count > 0)
            {
                return result[0].UserName;
            }
            else
                return null;
        }

        public Guid ReadLogIn(string userName, string password)
        {
            List<User> result = new List<User>();
            SqlParameter[] parameters = {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@Password", password)};
            result = Read("dbo.Users_ReadLogIn", parameters);
            if (result.Count > 0)
            {
                return result[0].UserID;
            }
            else
                return Guid.Empty;
        }

        protected override User GetModelFromReader(SqlDataReader reader)
        {
            User user = new User();
            user.UserID = reader.GetGuid(reader.GetOrdinal("UserID"));
            user.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
            user.LastName = reader.GetString(reader.GetOrdinal("LastName"));
            user.UserName = reader.GetString(reader.GetOrdinal("UserName"));
            user.Password = reader.GetString(reader.GetOrdinal("Password"));
            user.Role = reader.GetString(reader.GetOrdinal("Role"));
            user.CreationDate = reader.GetDateTime(reader.GetOrdinal("CreationDate"));
            user.Location = reader.GetString(reader.GetOrdinal("Location"));
            return (user);
        }
        #endregion
    }
}
