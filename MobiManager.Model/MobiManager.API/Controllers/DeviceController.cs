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

		[HttpPost]
		[Route("Insert")]
		public void Insert(Device device)
		{
			device.DeviceID = Guid.NewGuid();
			using (BusinessContext context = new BusinessContext())
			{
				context.DeviceBusiness.Insert(device);
			}
		}

		[HttpPost]
		[Route("Delete")]
		public void Delete(string deviceID)
		{
			using (BusinessContext context = new BusinessContext())
			{
				context.DeviceBusiness.Delete(deviceID);
			}
		}

		[HttpPost]
		[Route("Update")]
		public void Update(Device device)
		{
			using (BusinessContext context = new BusinessContext())
			{
				context.DeviceBusiness.Update(device);
			}
		}

		
	}
}