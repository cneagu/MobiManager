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
        public void string ReadUserName(string username)
        {
            using(RepositoryContext)
            {
                return;
            }
        }
    }
}