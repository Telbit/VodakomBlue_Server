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
        private readonly IMobileServiceRepository mobileServiceRepository;

        public MobileServiceController(IMobileServiceRepository _mobileService)
        {
            mobileServiceRepository = _mobileService;
        }

        [HttpGet]
        public async Task<IActionResult> GetService(int customerId) {
            if (customerId > 0)
            {
                return Ok(await mobileServiceRepository.GetServicesAsync(customerId));
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> AddService(MobileService _mobileService) {
            if (_mobileService != null) { 
                await mobileServiceRepository.AddServiceAsync(_mobileService);
                return Ok();
            }
            return BadRequest();

            // ?TODO? check if package is Added
        }

        [HttpDelete("serviceId")]
        public ActionResult DeleteService(int serviceId) {
            if (serviceId != 0) {
                MobileService mobileService = mobileServiceRepository.GetServiceAsync(serviceId).Result;
                if (mobileService != null) { 
                    mobileServiceRepository.DeleteService(mobileService);
                    return Ok();
                }
                return NotFound();
            }
            return BadRequest();
        }

        [HttpPut]
        public ActionResult UpdateService(MobileService _mobileService) {
            mobileServiceRepository.UpdateService(_mobileService);
            return Ok();
        }
    }
}
