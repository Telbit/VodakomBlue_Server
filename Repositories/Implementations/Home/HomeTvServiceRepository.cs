using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;
using VodakomBlue.Model;
using Microsoft.EntityFrameworkCore;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomeTvServiceRepository : IHomeTvServiceRepository
    {
        private readonly AppDbContext dbContext;

        public HomeTvServiceRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public async Task AddServiceAsync(HomeTvService newService)
        {
            await dbContext.HomeTvServices.AddAsync(newService);
            await dbContext.SaveChangesAsync();
        }

        public void DeleteService(HomeTvService service)
        {
            dbContext.HomeTvServices.Remove(service);
            dbContext.SaveChanges();
        }

        public async Task<IEnumerable<HomeTvService>> GetServicesAsync(int customerId)
        {
            return await dbContext.HomeTvServices.Where(service => service.Customer.Id == customerId).ToListAsync();
        }

        public void UpdateService(HomeTvService homeService)
        {
            var serviceToUpdate = dbContext.HomeTvServices.Attach(homeService);
            serviceToUpdate.State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
