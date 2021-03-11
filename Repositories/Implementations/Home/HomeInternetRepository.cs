using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomeInternetRepository : IHomeInternetRepository
    {
        public Task AddHomeInternetAsync(HomeInternet newHomeInternet)
        {
            throw new NotImplementedException();
        }

        public Task DeleteHomeInternetAsync(int homeInternetId)
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
