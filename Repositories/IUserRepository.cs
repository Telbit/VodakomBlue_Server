using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;


namespace VodakomBlue.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserAsync(int userId);
        Task<User> GetUserAsync(string phoneNumber);
        Task<User> GetUserAsync(string idCard, string firstName, string lastName);
        Task<User> GetUserAsync(Address clientAddress, DateTime birthDate,  string mothersName);
        void DeleteUser(int userId);
        void UpdateUser(User user);
        Task AddUserAsync(User newUser);






    }
}
