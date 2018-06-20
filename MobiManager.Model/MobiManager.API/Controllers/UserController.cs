using MobiManager.API.Models;
using MobiManager.Business.Core;
using MobiManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MobiManager.API.Controllers
{
    [RoutePrefix("api/User")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("LogIn/{userName}")]
        public string ReadUserName(string username)
        {
            using (BusinessContext context = new BusinessContext())
            {
                return context.UserBusiness.ReadUserName(username);
            }
        }

        [HttpPost]
        [Route("LogIn/Insert")]
        public void Insert(User user)
        {
            user.UserID = Guid.NewGuid();
            using (BusinessContext context = new BusinessContext())
            {
                context.UserBusiness.Insert(user);
            }
        }

        [HttpPost]
        [Route("LogIn/ReadLogIn")]
        public Guid ReadLogIn(LogInModel model)
        {
            using (BusinessContext context = new BusinessContext())
            {
                return context.UserBusiness.ReadLogIn(model.UserName, model.Password);
            }
        }

        [HttpGet]
        [Route("LogIn/ReadById/{userID}")]
        public User ReadById(Guid userID)
        {
            using (BusinessContext context = new BusinessContext())
            {
                return context.UserBusiness.ReadByID(userID);
            }
        }
    }
}