using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomeTVRepository : IHomeTVRepository
    {
        private readonly AppDbContext dbContext;

        public HomeTVRepository(AppDbContext context)
        {
            dbContext = context;
        }
        public Task AddHomeTvAsync(HomeTV newHomeTv)
        {
            throw new NotImplementedException();
        }

        public Task DeleteHomeTv(int homeTvId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HomeTV>> GetAllHomeTvASync()
        {
            throw new NotImplementedException();
        }

        public Task<HomeTV> GetHomeTvAsync(int homeTvId)
        {
            throw new NotImplementedException();
        }
    }
}
