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
    [RoutePrefix("api/Device")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DeviceController : ApiController
    {
        [HttpGet]
        [Route("ReadByID/{deviceID}")]
        public Device ReadByID(Guid deviceID)
        {
            using (BusinessContext context = new BusinessContext())
            {
                return context.DeviceBusiness.ReadByID(deviceID);
            }
        }

        //[HttpPost]
        //[Route("DevicesList")]
        //public List<DeviceUser> DevicesList(User user)
        //{
        //    using (BusinessContext context = new BusinessContext())
        //    {
        //        return context.DeviceUserBusiness.DevicesList();
        //    }
        //}
    }
}