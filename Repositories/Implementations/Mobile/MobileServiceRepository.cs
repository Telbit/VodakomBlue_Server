using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Mobile;
using VodakomBlue.Model;
using Microsoft.EntityFrameworkCore;

namespace VodakomBlue.Repositories.Implementations
{
    public class MobileServiceRepository : IMobileServiceRepository
    {
        private readonly AppDbContext dbContext;

        public MobileServiceRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public async Task AddServiceAsync(MobileService newService)
        {
            await dbContext.MobileServices.AddAsync(newService);
            await dbContext.SaveChangesAsync();
        }

        public void DeleteService(int serviceId, int customerId)
        {
            MobileService mobileService = 
                GetServicesAsync(customerId).Result.FirstOrDefault(service => service.Id == serviceId);
            dbContext.MobileServices.Remove(mobileService);
            dbContext.SaveChanges();
        }

        public async Task<IEnumerable<MobileService>> GetServicesAsync(int customerId)
        {
            return await dbContext.MobileServices.Where(service => service.Customer.Id == customerId).ToListAsync();
        }

        public void UpdateService(MobileService homeService)
        {
            var serviceToUpdate = dbContext.MobileServices.Attach(homeService);
            serviceToUpdate.State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
