using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories.Implementations
{

    
    public class AddressRepository : IAddressRepository
    {
        private readonly AppDbContext dbContext;

        public AddressRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public Task AddAddressAsync(Address newAddress)
        {
            throw new NotImplementedException();
        }

        public void DeleteAddress(int serviceId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Address>> GetServiceAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public void UpdateAddress(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
