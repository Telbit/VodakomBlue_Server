using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;


namespace VodakomBlue.Repositories
{
    public interface IHomePhoneServiceRepository
    {
        Task<IEnumerable<HomePhoneService>> GetServicesAsync(int customerId);
        Task AddServiceAsync(HomePhoneService newService);
        void UpdateService(HomePhoneService homeService);
        void DeleteService(HomePhoneService homeService);
    }
}
