using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Repositories
{
    public interface IHomeInternetServiceRepository
    {
        Task<IEnumerable<HomeInternetService>> GetAllServiceAsync(int userId);
        Task AddServiceAsync(HomeInternetService newService);
        Task UpdateServiceAsync(HomeInternetService homeService);
        Task DeleteServiceAsync(int serviceId);
    }
}
