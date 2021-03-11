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
        Task<User> GetUserAsync(string idCard, string fullName);
        Task<User> GetUserAsync(string fullName,  Address clientAddress, DateTime birthDate,  string mothersName);
        Task DeleteUserAsync(int userId);
        Task<User> UpdateUserAsync(User user);
        Task AddUserAsync(User newUser);






    }
}
