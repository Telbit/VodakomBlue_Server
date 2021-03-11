using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories
{
    public interface IAddressRepository
    {
        Task<IEnumerable<Address>> GetServiceAsync(int userId);
        Task AddAddressAsync(Address newAddress);
        Task UpdateAddressAsync(Address address);
        Task DeleteAddressAsync(int serviceId);
    }
}
