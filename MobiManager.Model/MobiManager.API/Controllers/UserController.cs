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
    }
}