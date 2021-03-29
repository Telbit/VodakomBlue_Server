using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;
using VodakomBlue.Repositories.Implementations;

namespace VodakomBlue.Controllers.HomeControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomePhoneServiceController : ControllerBase
    {
        private readonly HomePhoneServiceRepository homePhoneServiceRepository;

        public HomePhoneServiceController(HomePhoneServiceRepository homePhoneServiceRepository)
        {
            this.homePhoneServiceRepository = homePhoneServiceRepository;
        }

        [HttpGet("{homePhoneServiceId}")]
        public async Task<IActionResult> GetHomePhoneServices(int homePhoneServiceId)
        {
            if (homePhoneServiceId <= 0)
            {
                return BadRequest("Invalid home phone service ID");
            }
            return Ok(await homePhoneServiceRepository.GetServicesAsync(homePhoneServiceId));
        }

        [HttpPut]
        public IActionResult UpdateHomePhoneService(HomePhoneService homePhoneService)
        {
            if (homePhoneService == null)
            {
                return BadRequest("The provided home phone service is null");
            }
            homePhoneServiceRepository.UpdateService(homePhoneService);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteHomePhoneService(HomePhoneService homePhoneService)
        {
            if (homePhoneService == null)
            {
                return BadRequest("The provided phone service is null");
            }
            homePhoneServiceRepository.DeleteService(homePhoneService);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddHomePhoneService(HomePhoneService homePhoneService)
        {
            if (homePhoneService == null)
            {
                return BadRequest("The provided phone service is null");
            }
            await homePhoneServiceRepository.AddServiceAsync(homePhoneService);
            return Ok();
        }
    }
}
