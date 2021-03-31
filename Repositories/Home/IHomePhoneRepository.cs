using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;


namespace VodakomBlue.Repositories
{
    public interface IHomePhoneRepository
    {
        Task<HomePhone> GetHomePhoneAsync(int homePhoneId);
        Task<IEnumerable<HomePhone>> GetAllHomePhoneAsync();
        Task AddHomePhoneAsync(HomePhone newHomePhone);
        void UpdateService(HomePhone homePhonePackage);
        void DeleteHomePhone(HomePhone homePhone);
    }
}
