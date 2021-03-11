using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomeInternetServiceRepository : IHomeInternetServiceRepository
    {
        public Task AddServiceAsync(HomeInternetService newService)
        {
            throw new NotImplementedException();
        }

        public Task DeleteServiceAsync(int serviceId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HomeInternetService>> GetAllServiceAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateServiceAsync(HomeInternetService homeService)
        {
            throw new NotImplementedException();
        }
    }
}
