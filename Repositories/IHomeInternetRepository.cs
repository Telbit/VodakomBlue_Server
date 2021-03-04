using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Repositories
{
    public interface IHomeInternetRepository
    {
        Task<HomeInternet> GetHomeInternetAsync(int homeInternetId);
        Task GetAllHomeInternetAsync();
        Task AddHomeInternetAsync(HomeInternet newHomeInternet);
        Task DeleteHomeInternetAsync(int homeInternetId);
    }
}
