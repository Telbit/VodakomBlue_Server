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
    public class MobileInternetPackageController : ControllerBase
    {
        private readonly IMobileInternetPackageRepository mobileInternetPackage;

        public MobileInternetPackageController(IMobileInternetPackageRepository _mobileInternetPackage) {
            mobileInternetPackage = _mobileInternetPackage;
        }

        [HttpGet]
        public async Task<IActionResult> GetPackages() {
            return Ok(await mobileInternetPackage.GetAllPackageAsync());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetPackage(int packageId) {
            if (packageId > 0) { 
            return Ok(await mobileInternetPackage.GetPackageAsync(packageId));
            }
            return BadRequest("The given parameter is not valid!");
        }

        [HttpDelete]
        public ActionResult DeletePackage(MobileInternetPackage _mobileInternetPackage) {
                if (_mobileInternetPackage != null) {
                    mobileInternetPackage.DeletePackage(_mobileInternetPackage);
                    return Ok();
                }
                return BadRequest("The given parameter is not valid!");
        }

        [HttpPost]
        public async Task<IActionResult> AddPackage(MobileInternetPackage _mobileInternetPackage) {
            if (_mobileInternetPackage != null) {  
                await mobileInternetPackage.AddPackageAsync(_mobileInternetPackage);
                return Ok();
            }
            return BadRequest("The given parameter is not valid!");

            // ?TODO? check if package is Added

        }

    }
}
