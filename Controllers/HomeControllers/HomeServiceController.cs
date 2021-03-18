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
    public class HomeServiceController : ControllerBase
    {
        private readonly IHomeInternetServiceRepository HomeInternetService;
        private readonly IHomePhoneServiceRepository HomePhoneService;
        private readonly IHomeTvServiceRepository HomeTvService;

        public HomeServiceController(IHomeInternetServiceRepository homeInternetService, 
            IHomePhoneServiceRepository homePhoneService, IHomeTvServiceRepository homeTvService)
        {
            HomeInternetService = homeInternetService;
            HomePhoneService = homePhoneService;
            HomeTvService = homeTvService;
        }

        [HttpGet("/id")]
        public async Task<IEnumerable<HomeService>> GetHomeServices(int id)
        {
            List<HomeService> HomeServices = new List<HomeService>();
            HomeServices.Concat(await HomeInternetService.GetServicesAsync(id))
                        .Concat(await HomePhoneService.GetServicesAsync(id))
                        .Concat(await HomeTvService.GetServicesAsync(id))
                        .ToList();
            return HomeServices;
        }
    }
}
