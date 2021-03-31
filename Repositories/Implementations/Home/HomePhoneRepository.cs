using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;
using VodakomBlue.Model;
using Microsoft.EntityFrameworkCore;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomePhoneRepository : IHomePhoneRepository
    {
        private readonly AppDbContext dbContext;

        public HomePhoneRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public async Task AddHomePhoneAsync(HomePhone newHomePhone)
        {
            await dbContext.HomePhones.AddAsync(newHomePhone);
            await dbContext.SaveChangesAsync();
        }

        public void DeleteHomePhone(HomePhone homePhone)
        {
            dbContext.HomePhones.Remove(homePhone);
            dbContext.SaveChanges();
        }

        public async Task<IEnumerable<HomePhone>> GetAllHomePhoneAsync()
        {
            return await dbContext.HomePhones.ToListAsync();
        }

        public async Task<HomePhone> GetHomePhoneAsync(int homePhoneId)
        {
            return await dbContext.HomePhones.FindAsync(homePhoneId);
        }

        public void UpdateService(HomePhone homePhonePackage)
        {
            var serviceToUpdate = dbContext.HomePhones.Attach(homePhonePackage);
            serviceToUpdate.State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
