using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;
using Microsoft.EntityFrameworkCore;

namespace VodakomBlue.Repositories.Implementations
{

    
    public class AddressRepository : IAddressRepository
    {
        private readonly AppDbContext dbContext;

        public AddressRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public async Task AddAddressAsync(Address newAddress)
        {
            await dbContext.Addresses.AddAsync(newAddress);
            await dbContext.SaveChangesAsync();
        }
        
        public void DeleteAddress(int addressId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Address>> GetAddressesAsync(int userId)
        {
            return await dbContext.Addresses.Where(address => address.User.Id == userId).ToListAsync();
        }

        public void UpdateAddress(Address address)
        {
            var addressToUpdate = dbContext.Attach(address);
            addressToUpdate.State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
