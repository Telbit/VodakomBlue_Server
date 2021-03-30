using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Mobile;
using VodakomBlue.Model;
using Microsoft.EntityFrameworkCore;

namespace VodakomBlue.Repositories.Implementations
{
    public class MobileInternetPackageRepository : IMobileInternetPackageRepository
    {
        private readonly AppDbContext dbContext;
        

        public MobileInternetPackageRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public async Task AddPackageAsync(MobileInternetPackage newPackage)
        {
            await dbContext.MobileInternetPackages.AddAsync(newPackage);
            await dbContext.SaveChangesAsync();
        }

        public void DeletePackage(MobileInternetPackage mobileInternetPackage)
        {
            dbContext.MobileInternetPackages.Remove(mobileInternetPackage);
            dbContext.SaveChanges();
        }

        public async Task<IEnumerable<MobileInternetPackage>> GetAllPackageAsync()
        {
            return await dbContext.MobileInternetPackages.ToListAsync();
        }

        public async Task<MobileInternetPackage> GetPackageAsync(int packageId)
        {
            return await dbContext.MobileInternetPackages.FindAsync(packageId);       
        }
    }
}
