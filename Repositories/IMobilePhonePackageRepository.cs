using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Repositories
{
    public interface IMobilePhonePackageRepository
    {
        Task<MobilePhonePackage> GetPackageAsync(int packageId);
        Task<IEnumerable<MobilePhonePackage>> GetAllPackageAsync();
        Task AddPackageAsync(MobilePhonePackage newPackage);
        Task DeletePackageAsync(int packageId);
    }
}
