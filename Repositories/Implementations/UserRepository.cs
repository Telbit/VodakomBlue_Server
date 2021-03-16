using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
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

        public async Task AddUserAsync(User newUser)
        {
            await dbContext.Users.AddAsync(newUser);
            await dbContext.SaveChangesAsync();
        }

        public void DeleteUser(int userId)
        {
            User user = GetUserAsync(userId).Result;
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }

        public async Task<User> GetUserAsync(int userId)
        {
            return await dbContext.Users.FindAsync(userId);
        }

        public async Task<User> GetUserAsync(string phoneNumber)
        {
            return await dbContext.Users.FirstOrDefaultAsync(user => user.ContactPhoneNumber == phoneNumber);
        }

        public async Task<User> GetUserAsync(string idCard, string firstName, string lastName)
        {
            return await dbContext.Users.FirstOrDefaultAsync(user => user.IdCardNumber == idCard
            && user.FirstName == firstName && user.LastName == lastName);
        }

        public async Task<User> GetUserAsync(Address clientAddress, DateTime birthDate, string mothersName)
        {
            return await dbContext.Users.FirstOrDefaultAsync(user => user.Adresses.Contains(clientAddress) &&
            user.BirthDate == birthDate && user.MothersName == mothersName);
        }

        public void UpdateUser(User user)
        {
            var productToUpdate = dbContext.Attach(user);
            productToUpdate.State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
