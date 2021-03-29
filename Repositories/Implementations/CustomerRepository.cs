using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories.Implementations
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext dbContext;

        public CustomerRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public async Task AddCustomerAsync(Customer newUser)
        {
            await dbContext.Customers.AddAsync(newUser);
            await dbContext.SaveChangesAsync();
        }

        public void DeleteCustomer(Customer customer)
        {
            dbContext.Customers.Remove(customer);
        }

        public async Task<Customer> GetCustomerAsync(int userId)
        {
            return await dbContext.Customers.FindAsync(userId);
        }

        public async Task<Customer> GetCustomerAsync(string phoneNumber)
        {
            return await dbContext.Customers.FirstOrDefaultAsync(user => user.ContactPhoneNumber == phoneNumber);
        }

        public async Task<Customer> GetCustomerAsync(string idCard, string firstName, string lastName)
        {
            return await dbContext.Customers.FirstOrDefaultAsync(customer => customer.IdCardNumber == idCard
            && customer.FirstName == firstName && customer.LastName == lastName);
        }

        public async Task<Customer> GetCustomerAsync(Address clientAddress, DateTime birthDate, string mothersName)
        {
            return await dbContext.Customers.FirstOrDefaultAsync(customer => customer.Adresses.Contains(clientAddress) &&
            customer.BirthDate == birthDate && customer.MothersName == mothersName);
        }

        public void UpdateCustomer(Customer customer)
        {
            var customerToUpdate = dbContext.Customers.Attach(customer);
            customerToUpdate.State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
