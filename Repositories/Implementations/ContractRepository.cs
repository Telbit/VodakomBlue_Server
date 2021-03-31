using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;
using Microsoft.EntityFrameworkCore;

namespace VodakomBlue.Repositories.Implementations
{
    public class ContractRepository : IContractRepository
    {
        private readonly AppDbContext dbContext;

        public ContractRepository(AppDbContext context)
        {
            dbContext = context;
        }
        public async Task AddContractAsync(Contract contract)
        {
            await dbContext.Contracts.AddAsync(contract);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Contract>> GetAllContractAsync(int customerId)
        {
            return await dbContext.Contracts.Where(contract => contract.Customer.Id == customerId).ToListAsync();
        }

        
    }
}
