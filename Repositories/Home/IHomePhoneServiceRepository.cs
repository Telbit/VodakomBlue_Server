using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;


namespace VodakomBlue.Repositories
{
    public interface IHomePhoneServiceRepository
    {
        Task<IEnumerable<HomePhoneService>> GetAllServiceAsync(int userId);
        Task AddServiceAsync(HomePhoneService newService);
        void UpdateService(HomePhoneService homeService);
        void DeleteService(int serviceId, int userId);
    }
}
