using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Mobile;


namespace VodakomBlue.Repositories
{
    interface IMobileInternetPackageRepository
    {
        Task<MobileInternetPackage> GetPackageAsync(int packageId);
        Task<IEnumerable<MobileInternetPackage>> GetAllPackageAsync();
        Task AddPackageAsync(MobileInternetPackage newPackage);
        Task DeletePackageAsync(int packageId);

    }
}
