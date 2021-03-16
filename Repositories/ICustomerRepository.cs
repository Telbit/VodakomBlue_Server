using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;


namespace VodakomBlue.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomerAsync(int customerId);
        Task<Customer> GetCustomerAsync(string phoneNumber);
        Task<Customer> GetCustomerAsync(string idCard, string firstName, string lastName);
        Task<Customer> GetCustomerAsync(Address clientAddress, DateTime birthDate,  string mothersName);
        void DeleteCustomer(int customerId);
        void UpdateCustomer(Customer customer);
        Task AddCustomerAsync(Customer newcustomer);






    }
}
