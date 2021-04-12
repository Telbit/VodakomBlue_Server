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

        public async Task<int> AddAddressAsync(Address newAddress)
        {
            await dbContext.Addresses.AddAsync(newAddress);
            await dbContext.SaveChangesAsync();
            return newAddress.Id;
        }
        
        public void DeleteAddress(Address address)
        {
            dbContext.Addresses.Remove(address);
            dbContext.SaveChanges();
        }

        public async Task<IEnumerable<Address>> GetAddressesAsync(int customerId)
        {
            return await dbContext.Addresses.Where(address => address.Customer.Id == customerId).ToListAsync();
        }

        public void UpdateAddress(Address address)
        {
            var adressToModify = dbContext.Addresses.Attach(address);
            adressToModify.State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public async Task<Address> GetAddressAsync(int addressId)
        {
            return await dbContext.Addresses.FindAsync(addressId);
        }
    }
}
