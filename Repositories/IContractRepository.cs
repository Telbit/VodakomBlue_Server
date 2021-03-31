using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;


namespace VodakomBlue.Repositories
{
    public interface IContractRepository
    {
        Task AddContractAsync(Contract contract);
        Task<IEnumerable<Contract>> GetAllContractAsync(int customerId);
    }
}
