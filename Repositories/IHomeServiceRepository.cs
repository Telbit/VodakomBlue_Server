using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Repositories
{
    public interface IHomeServiceRepository
    {
        Task<IEnumerable<HomeService>> GetServiceAsync(int userId);
        Task AddServiceAsync(HomeService newService);
        Task UpdateServiceAsync(HomeService homeService);
        Task DeleteServiceAsync(int serviceId);
    }
}
