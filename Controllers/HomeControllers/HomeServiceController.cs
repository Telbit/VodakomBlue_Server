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
        private readonly IHomeInternetServiceRepository HomeInternetServiceRepository;
        private readonly IHomePhoneServiceRepository HomePhoneServiceRepository;
        private readonly IHomeTvServiceRepository HomeTvServiceRepository;

        public HomeServiceController(IHomeInternetServiceRepository homeInternetServiceRepository, 
            IHomePhoneServiceRepository homePhoneServiceRepository, IHomeTvServiceRepository homeTvServiceRepository)
        {
            HomeInternetServiceRepository = homeInternetServiceRepository;
            HomePhoneServiceRepository = homePhoneServiceRepository;
            HomeTvServiceRepository = homeTvServiceRepository;
        }

        [HttpGet("{customerId}")]
        public async Task<IEnumerable<HomeService>> GetAllHomeServices(int customerId)
        {
            List<HomeService> HomeServices = new List<HomeService>();
            HomeServices.Concat(await HomeInternetServiceRepository.GetServicesAsync(customerId))
                        .Concat(await HomePhoneServiceRepository.GetServicesAsync(customerId))
                        .Concat(await HomeTvServiceRepository.GetServicesAsync(customerId))
                        .ToList();
            return HomeServices;
        }
    }
}
