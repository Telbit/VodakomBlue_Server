using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories.Implementations
{
    public class ContractRepository : IContractRepository
    {
        private readonly AppDbContext dbContext;

        public ContractRepository(AppDbContext context)
        {
            dbContext = context;
        }
        public Task AddContractAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<Contract> GetContractAsync(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
