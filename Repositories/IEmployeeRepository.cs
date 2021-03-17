using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;

namespace VodakomBlue.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployeeAsync(int employeeId);
        Task AddEmployeeAsync(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
    }
}
