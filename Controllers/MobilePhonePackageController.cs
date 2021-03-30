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
            if (packageId > 0) { 
            return Ok(await mobilePhonePackageRepository.GetPackageAsync(packageId));        
            }
            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetPackages() {
            return Ok(await mobilePhonePackageRepository.GetAllPackageAsync());
        }

        [HttpDelete]
        public ActionResult DeletePackage(MobilePhonePackage mobilePhonePackage)
        {
                if (mobilePhonePackage != null)
                {
                    mobilePhonePackageRepository.DeletePackage(mobilePhonePackage);
                    return Ok();
                }
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AddPackage(MobilePhonePackage _mobilePhonePackage) {
            if (_mobilePhonePackage != null) { 
                await mobilePhonePackageRepository.AddPackageAsync(_mobilePhonePackage);
                return Ok();
            }
            return BadRequest();

            // ?TODO? check if package is Added
        }


    }
}
