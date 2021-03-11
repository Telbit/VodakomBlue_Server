using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Mobile;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories.Implementations
{
    public class MobileServiceRepository : IMobileServiceRepository
    {
        private readonly AppDbContext dbContext;

        public MobileServiceRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public Task AddServiceAsync(MobileService newService)
        {
            throw new NotImplementedException();
        }

        public void DeleteService(int serviceId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MobileService>> GetServiceAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public void UpdateService(MobileService homeService)
        {
            throw new NotImplementedException();
        }
    }
}
