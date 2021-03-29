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
    public class HomeTvController : ControllerBase
    {
        private readonly HomeTVRepository homeTvRepository;

        public HomeTvController(HomeTVRepository homeTvRepository)
        {
            this.homeTvRepository = homeTvRepository;
        }

        [HttpGet("{homeTvPackageId}")]
        public async Task<IActionResult> GetHomeTvPackage(int homeTvPackageId)
        {
            if (homeTvPackageId <= 0)
            {
                return BadRequest("Invalid home Tv ID");
            }
            return Ok(await homeTvRepository.GetHomeTvAsync(homeTvPackageId));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHomeTvPackages()
        {
            return Ok(await homeTvRepository.GetAllHomeTvASync());
        }

        [HttpDelete]
        public IActionResult DeleteHomeTvPackage(HomeTV homeTvPackage)
        {
            if (homeTvPackage == null)
            {
                return BadRequest("The provided Tv package is null");
            }
            homeTvRepository.DeleteHomeTv(homeTvPackage);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddHomeTvPackage(HomeTV homeTvPackage)
        {
            if (homeTvPackage == null)
            {
                return BadRequest("The provided Tv package is null");
            }
            await homeTvRepository.AddHomeTvAsync(homeTvPackage);
            return Ok();
        }
    }
}
