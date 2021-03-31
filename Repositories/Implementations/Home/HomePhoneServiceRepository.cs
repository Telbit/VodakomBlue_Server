using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;
using VodakomBlue.Model;
using Microsoft.EntityFrameworkCore;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomePhoneServiceRepository : IHomePhoneServiceRepository
    {
        private readonly AppDbContext dbContext;

        public HomePhoneServiceRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public async Task AddServiceAsync(HomePhoneService newService)
        {
            await dbContext.HomePhoneServices.AddAsync(newService);
            await dbContext.SaveChangesAsync();
        }

        public void DeleteService(HomePhoneService service)
        {
            dbContext.HomePhoneServices.Remove(service);
            dbContext.SaveChanges();
        }

        public async Task<IEnumerable<HomePhoneService>> GetServicesAsync(int customerId)
        {
            return await dbContext.HomePhoneServices.Where(service => service.Customer.Id == customerId).ToListAsync();
        }

        public void UpdateService(HomePhoneService homeService)
        {
            var homeServiceToUpdate = dbContext.HomePhoneServices.Attach(homeService);
            homeServiceToUpdate.State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
