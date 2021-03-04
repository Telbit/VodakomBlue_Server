using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Repositories
{
    public interface IHomePhoneRepository
    {
        Task<HomePhone> GetHomePhoneAsync(int homePhoneId);
        Task AddHomePhoneAsync(HomePhone newHomePhone);
        Task DeleteHomePhoneAsync(int homePhoneId);
    }
}
