using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;
using VodakomBlue.Model;
using Microsoft.EntityFrameworkCore;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomeInternetServiceRepository : IHomeInternetServiceRepository
    {
        private readonly AppDbContext dbContext;

        public HomeInternetServiceRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public async Task AddServiceAsync(HomeInternetService newService)
        {
            await dbContext.HomeInternetServices.AddAsync(newService);
            await dbContext.SaveChangesAsync();
        }

        public void DeleteService(HomeInternetService service)
        {
            dbContext.HomeInternetServices.Remove(service);
            dbContext.SaveChanges();
        }

        public async Task<IEnumerable<HomeInternetService>> GetServicesAsync(int customerId)
        {
            return await dbContext.HomeInternetServices.Where(service => service.Customer.Id == customerId).ToListAsync();
        }

        public void UpdateService(HomeInternetService homeService)
        {
            var homeServiceToUpdate = dbContext.Attach(homeService);
            homeServiceToUpdate.State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
