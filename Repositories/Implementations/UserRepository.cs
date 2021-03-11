using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        public Task AddUserAsync(User newUser)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserAsync(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserAsync(string idCard, string fullName)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserAsync(string fullName, Address clientAddress, DateTime birthDate, string mothersName)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
