using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomePhoneServiceRepository : IHomePhoneServiceRepository
    {
        private readonly AppDbContext dbContext;

        public HomePhoneServiceRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public Task AddServiceAsync(HomePhoneService newService)
        {
            throw new NotImplementedException();
        }

        public void DeleteService(int serviceId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HomePhoneService>> GetAllServiceAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public void UpdateService(HomePhoneService homeService)
        {
            throw new NotImplementedException();
        }
    }
}
