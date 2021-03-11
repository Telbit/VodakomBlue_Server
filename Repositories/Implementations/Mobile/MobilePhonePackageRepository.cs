using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Mobile;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories.Implementations
{
    public class MobilePhonePackageRepository : IMobilePhonePackageRepository
    {
        private readonly AppDbContext dbContext;

        public MobilePhonePackageRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public Task AddPackageAsync(MobilePhonePackage newPackage)
        {
            throw new NotImplementedException();
        }

        public void DeletePackage(int packageId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MobilePhonePackage>> GetAllPackageAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MobilePhonePackage> GetPackageAsync(int packageId)
        {
            throw new NotImplementedException();
        }
    }
}
