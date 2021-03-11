using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;


namespace VodakomBlue.Repositories
{
    public interface IHomeInternetServiceRepository
    {
        Task<IEnumerable<HomeInternetService>> GetAllServiceAsync(int userId);
        Task AddServiceAsync(HomeInternetService newService);
        void UpdateService(HomeInternetService homeService);
        void DeleteService(int serviceId);
    }
}
