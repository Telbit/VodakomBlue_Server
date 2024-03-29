﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;


namespace VodakomBlue.Repositories
{
    public interface IContractRepository
    {
        Task<Contract> GetContractAsync(int customerId);
        Task AddContractAsync(Contract contract);
    }
}
