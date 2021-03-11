using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomePhoneRepository : IHomePhoneRepository
    {
        public Task AddHomePhoneAsync(HomePhone newHomePhone)
        {
            throw new NotImplementedException();
        }

        public Task DeleteHomePhoneAsync(int homePhoneId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HomePhone>> GetAllHomePhoneAsync()
        {
            throw new NotImplementedException();
        }

        public Task<HomePhone> GetHomePhoneAsync(int homePhoneId)
        {
            throw new NotImplementedException();
        }
    }
}
