using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomeInternetRepository : IHomeInternetRepository
    {
        private readonly AppDbContext dbContext;

        public HomeInternetRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public Task AddHomeInternetAsync(HomeInternet newHomeInternet)
        {
            throw new NotImplementedException();
        }

        public void DeleteHomeInternet(int homeInternetId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HomeInternet>> GetAllHomeInternetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<HomeInternet> GetHomeInternetAsync(int homeInternetId)
        {
            throw new NotImplementedException();
        }
    }
}
