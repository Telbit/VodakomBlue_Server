using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;


namespace VodakomBlue.Repositories
{
    public interface IHomeInternetRepository
    {
        Task<HomeInternet> GetHomeInternetAsync(int homeInternetId);
        Task<IEnumerable<HomeInternet>> GetAllHomeInternetAsync();
        Task AddHomeInternetAsync(HomeInternet newHomeInternet);
        void DeleteHomeInternet(int homeInternetId);
    }
}
