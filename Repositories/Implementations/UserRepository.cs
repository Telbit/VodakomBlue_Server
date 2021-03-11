using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext dbContext;

        public UserRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public Task AddUserAsync(User newUser)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int userId)
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

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
