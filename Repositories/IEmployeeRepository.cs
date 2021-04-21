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
        Task<IEnumerable<Employee>> GetEmployeesAsync();
        Task AddEmployeeAsync(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
