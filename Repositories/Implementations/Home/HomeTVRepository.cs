using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;
using VodakomBlue.Model;
using Microsoft.EntityFrameworkCore;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomeTVRepository : IHomeTVRepository
    {
        private readonly AppDbContext dbContext;

        public HomeTVRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public async Task AddHomeTvAsync(HomeTV newHomeTv)
        {
            await dbContext.HomeTVs.AddAsync(newHomeTv);
            await dbContext.SaveChangesAsync();
        }

        public void DeleteHomeTv(HomeTV homeTv)
        {
            dbContext.HomeTVs.Remove(homeTv);
            dbContext.SaveChanges();
        }

        public async Task<IEnumerable<HomeTV>> GetAllHomeTvASync()
        {
            return await dbContext.HomeTVs.ToListAsync();
        }

        public async Task<HomeTV> GetHomeTvAsync(int homeTvId)
        {
            return await dbContext.HomeTVs.FindAsync(homeTvId);
        }
    }
}
