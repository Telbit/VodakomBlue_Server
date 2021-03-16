using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Repositories
{
    public interface IMobileServiceRepository
    {
        Task<IEnumerable<MobileService>> GetServiceAsync(int userId);
        Task AddServiceAsync(MobileService newService);
        Task UpdateServiceAsync(MobileService homeService);
        Task DeleteServiceAsync(int serviceId);
    }
}
