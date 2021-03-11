using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Mobile;

namespace VodakomBlue.Repositories.Implementations
{
    public class MobileInternetPackageRepository : IMobileInternetPackageRepository
    {
        public Task AddPackageAsync(MobileInternetPackage newPackage)
        {
            throw new NotImplementedException();
        }

        public Task DeletePackageAsync(int packageId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MobileInternetPackage>> GetAllPackageAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MobileInternetPackage> GetPackageAsync(int packageId)
        {
            throw new NotImplementedException();
        }
    }
}
