using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Mobile;

namespace VodakomBlue.Repositories.Implementations
{
    public class MobilePhonePackageRepository : IMobilePhonePackageRepository
    {
        public Task AddPackageAsync(MobilePhonePackage newPackage)
        {
            throw new NotImplementedException();
        }

        public Task DeletePackageAsync(int packageId)
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
