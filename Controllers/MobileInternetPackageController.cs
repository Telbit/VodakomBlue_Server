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
            return Ok(await mobileInternetPackage.GetPackageAsync(packageId));
        }

        [HttpDelete]
        public ActionResult DeletePackage(int packageId) {
            if (packageId != 0) {
                mobileInternetPackage.DeletePackage(packageId);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost()]
        public async Task<IActionResult> AddPackage(MobileInternetPackage _mobileInternetPackage) {
            await mobileInternetPackage.AddPackageAsync(_mobileInternetPackage);
            return Ok();

            // ?TODO? check if package is Added
        
        }

    }
}
