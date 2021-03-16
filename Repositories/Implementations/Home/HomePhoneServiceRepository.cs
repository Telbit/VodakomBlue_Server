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

        public void DeleteService(int serviceId, int userId)
        {
            HomePhoneService homePhoneService = 
                GetServicesAsync(userId).Result.FirstOrDefault(service => service.Id == serviceId);
            dbContext.Remove(homePhoneService);
            dbContext.SaveChanges();
        }

        public async Task<IEnumerable<HomePhoneService>> GetServicesAsync(int userId)
        {
            return await dbContext.HomePhoneServices.Where(service => service.User.Id == userId).ToListAsync();
        }

        public void UpdateService(HomePhoneService homeService)
        {
            var homeServiceToUpdate = dbContext.Attach(homeService);
            homeServiceToUpdate.State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
