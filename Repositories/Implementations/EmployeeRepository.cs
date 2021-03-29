using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;
using Microsoft.EntityFrameworkCore;

namespace VodakomBlue.Repositories.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext dbContext;

        public EmployeeRepository(AppDbContext context)
        {
            dbContext = context;
        }
        public async Task AddEmployeeAsync(Employee employee)
        {
            await dbContext.Employees.AddAsync(employee);
            await dbContext.SaveChangesAsync();
        }
        public void DeleteEmployee(Employee employee)
        {
            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();
        }

        public async Task<Employee> GetEmployeeAsync(int employeeId)
        {
            return await dbContext.Employees.FindAsync(employeeId);
        }

        public void UpdateEmployee(Employee employee)
        {
            var employeeToUpdate = dbContext.Employees.Attach(employee);
            employeeToUpdate.State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
