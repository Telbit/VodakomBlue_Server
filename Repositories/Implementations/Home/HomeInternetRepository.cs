using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;
using VodakomBlue.Model;
using Microsoft.EntityFrameworkCore;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomeInternetRepository : IHomeInternetRepository
    {
        private readonly AppDbContext dbContext;

        public HomeInternetRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public async Task AddHomeInternetAsync(HomeInternet newHomeInternet)
        {
            await dbContext.HomeInternets.AddAsync(newHomeInternet);
            await dbContext.SaveChangesAsync();
        }

        public void DeleteHomeInternet(HomeInternet homeInternet)
        {
            dbContext.HomeInternets.Remove(homeInternet);
            dbContext.SaveChanges();
        }

        public async Task<IEnumerable<HomeInternet>> GetAllHomeInternetAsync()
        {
            return await dbContext.HomeInternets.ToListAsync();
        }

        public async Task<HomeInternet> GetHomeInternetAsync(int homeInternetId)
        {
            return await dbContext.HomeInternets.FindAsync(homeInternetId);
        }

        public void UpdatePackage(HomeInternet homeInternetPackage)
        {
            var serviceToUpdate = dbContext.HomeInternets.Attach(homeInternetPackage);
            serviceToUpdate.State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
