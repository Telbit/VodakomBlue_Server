using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomeInternetServiceRepository : IHomeInternetServiceRepository
    {
        private readonly AppDbContext dbContext;

        public HomeInternetServiceRepository(AppDbContext context)
        {
            dbContext = context;
        }
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
