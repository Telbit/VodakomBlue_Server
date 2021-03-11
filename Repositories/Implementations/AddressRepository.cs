using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories.Implementations
{
    public class AddressRepository : IAddressRepository
    {
        public Task AddAddressAsync(Address newAddress)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAddressAsync(int serviceId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Address>> GetServiceAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAddressAsync(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
