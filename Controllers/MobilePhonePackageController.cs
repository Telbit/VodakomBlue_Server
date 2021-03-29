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
    public class MobilePhonePackageController : ControllerBase
    {
        private readonly IMobilePhonePackageRepository mobilePhonePackageRepository;

        public MobilePhonePackageController(IMobilePhonePackageRepository _mobilePhonePackageRepository)
        {
            mobilePhonePackageRepository = _mobilePhonePackageRepository;
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetPackage(int packageId) {
            return Ok(await mobilePhonePackageRepository.GetPackageAsync(packageId));
        }

        [HttpGet]
        public async Task<IActionResult> GetPackages() {
            return Ok(await mobilePhonePackageRepository.GetAllPackageAsync());
        }

        [HttpDelete]
        public ActionResult DeletePackage(int packageId) {
            if (packageId != 0) {
                mobilePhonePackageRepository.DeletePackage(packageId);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> AddPackage(MobilePhonePackage _mobilePhonePackage) {
            await mobilePhonePackageRepository.AddPackageAsync(_mobilePhonePackage);
            return Ok();

            // ?TODO? check if package is Added
        }


    }
}
