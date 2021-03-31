using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;
using VodakomBlue.Repositories;

namespace VodakomBlue.Controllers.HomeControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeInternetServiceController : ControllerBase
    {
        private readonly IHomeInternetServiceRepository HomeInternetServiceRepository;

        public HomeInternetServiceController(IHomeInternetServiceRepository homeInternetServiceRepository)
        {
            HomeInternetServiceRepository = homeInternetServiceRepository;
        }

        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetAllHomeInternetService(int customerId)
        {
            if (customerId <= 0)
            {
                return BadRequest("Invalid Customer ID");
            }
            return Ok(await HomeInternetServiceRepository.GetServicesAsync(customerId));
        }

        [HttpPost]
        public async Task<IActionResult> AddHomeInternetService(HomeInternetService newInternetService)
        {
            if (newInternetService == null)
            {
                return BadRequest("The provided internet service is null");
            }
            await HomeInternetServiceRepository.AddServiceAsync(newInternetService);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateService(HomeInternetService newInternetService)
        {
            if (newInternetService == null)
            {
                return BadRequest("The provided internet service is null");
            }
            HomeInternetServiceRepository.UpdateService(newInternetService);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteService(HomeInternetService internetService)
        {
            if (internetService != null)
            {
                HomeInternetServiceRepository.DeleteService(internetService);
                return Ok();
            }
            return BadRequest("The provided internet service is null");
        }
    }
}
