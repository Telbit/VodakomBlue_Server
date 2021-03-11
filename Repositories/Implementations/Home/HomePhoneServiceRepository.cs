using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomePhoneServiceRepository : IHomePhoneServiceRepository
    {
        public Task AddServiceAsync(HomePhoneService newService)
        {
            throw new NotImplementedException();
        }

        public Task DeleteServiceAsync(int serviceId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HomePhoneService>> GetAllServiceAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateServiceAsync(HomePhoneService homeService)
        {
            throw new NotImplementedException();
        }
    }
}
