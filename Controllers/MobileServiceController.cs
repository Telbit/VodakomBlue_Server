using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Mobile;
using VodakomBlue.Repositories;

namespace VodakomBlue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileServiceController : ControllerBase
    {
        private readonly IMobileServiceRepository mobileService;

        public MobileServiceController(IMobileServiceRepository _mobileService)
        {
            mobileService = _mobileService;
        }

        [HttpGet]
        public async Task<IActionResult> GetService(int customerId) {
            return Ok(await mobileService.GetServicesAsync(customerId));   
        }

        [HttpPost]
        public async Task<IActionResult> AddService(MobileService _mobileService) {
            await mobileService.AddServiceAsync(_mobileService);
            return Ok();

            // ?TODO? check if package is Added
        }

        [HttpDelete]
        public ActionResult DeleteService(int serviceId) {
            if (serviceId != 0) {
                mobileService.DeleteService(serviceId);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut]
        public ActionResult UpdateService(MobileService _mobileService) {
            mobileService.UpdateService(_mobileService);
            return Ok();
        }
    }
}
