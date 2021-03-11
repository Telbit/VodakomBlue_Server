using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomePhoneRepository : IHomePhoneRepository
    {
        private readonly AppDbContext dbContext;

        public HomePhoneRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public Task AddHomePhoneAsync(HomePhone newHomePhone)
        {
            throw new NotImplementedException();
        }

        public void DeleteHomePhone(int homePhoneId)
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
