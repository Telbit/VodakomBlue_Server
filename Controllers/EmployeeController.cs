using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Repositories;
using VodakomBlue.Model;

namespace VodakomBlue.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeService;

        public EmployeeController(IEmployeeRepository service)
        {
            employeeService = service;
        }

        [HttpGet("id")]
        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await employeeService.GetEmployeeAsync(employeeId);

        }

        [HttpPost]
        public async Task AddEmployee(Employee newEmployee)
        {
             await employeeService.AddEmployeeAsync(newEmployee);
        }

        [HttpDelete("id")]
        public void DeleteEmployee(int employeeId)
        {
            employeeService.DeleteEmployee(employeeId);
        }

        [HttpPut]
        public void UpdateEmployee(Employee employee)
        {
            employeeService.UpdateEmployee(employee);
        }

    }
}
