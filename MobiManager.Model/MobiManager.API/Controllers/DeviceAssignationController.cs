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
    [RoutePrefix("api/DeviceAssignation")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DeviceAssignationController : ApiController
    {
        [HttpPost]
        [Route("SetUser")]
        public void SetUser(DeviceAssignation deviceAssignation)
        {
            using (BusinessContext context = new BusinessContext())
            {
                 context.DeviceAssignationBusiness.SetUser(deviceAssignation);
            }
        }

        [HttpPost]
        [Route("RemoveUser")]
        public void RemoveUser(Guid deviceID)
        {
            using (BusinessContext context = new BusinessContext())
            {
                context.DeviceAssignationBusiness.RemoveUser(deviceID);
            }
        }

        [HttpGet]
        [Route("GetFreeDevice")]
        public List<DeviceAssignation> GetFreeDevice()
        {
            using (BusinessContext context = new BusinessContext())
            {
                return context.DeviceAssignationBusiness.GetFreeDevice();
            }
        }

        [HttpGet]
        [Route("ReadByID/{deviceID}")]
        public List<DeviceAssignation> ReadByID(Guid deviceID)
        {
            using (BusinessContext context = new BusinessContext())
            {
                return context.DeviceAssignationBusiness.ReadByID(deviceID);
            }
        }
    }
}