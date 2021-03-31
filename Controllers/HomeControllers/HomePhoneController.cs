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
    public class HomePhoneController : ControllerBase
    {
        private readonly IHomePhoneRepository homePhoneRepository;

        public HomePhoneController(IHomePhoneRepository homePhoneRepository)
        {
            this.homePhoneRepository = homePhoneRepository;
        }

        [HttpGet("{homePhonePackageId}")]
        public async Task<IActionResult> GetHomePhonePackage(int homePhonePackageId)
        {
            if (homePhonePackageId <= 0)
            {
                return BadRequest("Invalid home phone ID");
            }
            return Ok(await homePhoneRepository.GetHomePhoneAsync(homePhonePackageId));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHomePhonePackages()
        {
            return Ok(await homePhoneRepository.GetAllHomePhoneAsync());
        }

        [HttpDelete]
        public IActionResult DeleteHomePhonePackage(HomePhone homePhonePackage)
        {
            if (homePhonePackage == null)
            {
                return BadRequest("The provided phone package is null");
            }
            homePhoneRepository.DeleteHomePhone(homePhonePackage);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddHomePhonePackage(HomePhone homePhonePackage)
        {
            if (homePhonePackage == null)
            {
                return BadRequest("The provided phone package is null");
            }
            await homePhoneRepository.AddHomePhoneAsync(homePhonePackage);
            return Ok();
        }
    }
}
