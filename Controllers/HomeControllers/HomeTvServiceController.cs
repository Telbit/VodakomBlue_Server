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
    public class HomeTvServiceController : ControllerBase
    {
        private readonly HomeTvServiceRepository homeTvServiceRepository;

        public HomeTvServiceController(HomeTvServiceRepository homeTvServiceRepository)
        {
            this.homeTvServiceRepository = homeTvServiceRepository;
        }

        [HttpGet("{homeTvServiceId}")]
        public async Task<IActionResult> GetHomeTvServices(int homeTvServiceId)
        {
            if (homeTvServiceId <= 0)
            {
                return BadRequest("Invalid home Tv service ID");
            }
            return Ok(await homeTvServiceRepository.GetServicesAsync(homeTvServiceId));
        }

        [HttpPut]
        public IActionResult UpdateHomeTvService(HomeTvService homeTvService)
        {
            if (homeTvService == null)
            {
                return BadRequest("The provided home Tv service is null");
            }
            homeTvServiceRepository.UpdateService(homeTvService);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteHomeTvService(HomeTvService homeTvService)
        {
            if (homeTvService == null)
            {
                return BadRequest("The provided Tv service is null");
            }
            homeTvServiceRepository.DeleteService(homeTvService);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddHomeTvService(HomeTvService homeTvService)
        {
            if (homeTvService == null)
            {
                return BadRequest("The provided Tv service is null");
            }
            await homeTvServiceRepository.AddServiceAsync(homeTvService);
            return Ok();
        }
    }
}
