using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Mobile;


namespace VodakomBlue.Repositories
{
    public interface IMobilePhonePackageRepository
    {
        Task<MobilePhonePackage> GetPackageAsync(int packageId);
        Task<IEnumerable<MobilePhonePackage>> GetAllPackageAsync();
        Task AddPackageAsync(MobilePhonePackage newPackage);
        void DeletePackage(int packageId);
    }
}
