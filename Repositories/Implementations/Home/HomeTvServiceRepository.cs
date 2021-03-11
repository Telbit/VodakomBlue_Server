using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomeTvServiceRepository : IHomeTvServiceRepository
    {
        private readonly AppDbContext dbContext;

        public HomeTvServiceRepository(AppDbContext context)
        {
            dbContext = context;
        }
        public Task AddServiceAsync(HomeTvService newService)
        {
            throw new NotImplementedException();
        }

        public Task DeleteServiceAsync(int serviceId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HomeTvService>> GetAllServiceAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateServiceAsync(HomeTvService homeService)
        {
            throw new NotImplementedException();
        }
    }
}
