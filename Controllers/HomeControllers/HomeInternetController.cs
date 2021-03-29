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
    public class HomeInternetController : ControllerBase
    {
        private readonly HomeInternetRepository homeInternetRepository;

        public HomeInternetController(HomeInternetRepository homeInternetRepository)
        {
            this.homeInternetRepository = homeInternetRepository;
        }

        [HttpGet("{homeInternetPackageId}")]
        public async Task<IActionResult> GetHomeInternetPackage(int homeInternetPackageId)
        {
            if (homeInternetPackageId <= 0)
            {
                return BadRequest("Invalid home internet ID");
            }
            return Ok(await homeInternetRepository.GetHomeInternetAsync(homeInternetPackageId));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHomeInternetPackages()
        {
            return Ok(await homeInternetRepository.GetAllHomeInternetAsync());
        }

        [HttpDelete]
        public IActionResult DeleteHomeInternetPackage(HomeInternet homeInternetPackage)
        {
            if (homeInternetPackage == null)
            {
                return BadRequest("The provided internet package is null");
            }
            homeInternetRepository.DeleteHomeInternet(homeInternetPackage);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddHomeInternetPackage(HomeInternet newHomeInternetPackage)
        {
            if (newHomeInternetPackage == null)
            {
                return BadRequest("The provided internet package is null");
            }
            await homeInternetRepository.AddHomeInternetAsync(newHomeInternetPackage);
            return Ok();
        }
    }
}
