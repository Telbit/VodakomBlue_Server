using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;


namespace VodakomBlue.Repositories
{
    public interface IHomeInternetServiceRepository
    {
        Task<IEnumerable<HomeInternetService>> GetServicesAsync(int customerId);
        Task AddServiceAsync(HomeInternetService newService);
        void UpdateService(HomeInternetService homeService);
        void DeleteService(int serviceId, int customerId);
    }
}
