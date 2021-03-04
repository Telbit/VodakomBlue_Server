using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Repositories
{
    public interface IHomePhoneServiceRepository
    {
        Task<IEnumerable<HomePhoneService>> GetServiceAsync(int userId);
        Task AddServiceAsync(HomePhoneService newService);
        Task UpdateServiceAsync(HomePhoneService homeService);
        Task DeleteServiceAsync(int serviceId);
    }
}
