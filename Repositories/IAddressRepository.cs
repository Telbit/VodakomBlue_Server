using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories
{
    public interface IAddressRepository
    {
        Task<IEnumerable<Address>> GetAddressesAsync(int customerId);
        Task<Address> GetAddressAsync(int addressId);
        Task<int> AddAddressAsync(Address newAddress);
        void UpdateAddress(Address address);
        void DeleteAddress(Address address);
    }
}
