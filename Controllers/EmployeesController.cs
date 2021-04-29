using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Repositories;
using VodakomBlue.Model;

namespace VodakomBlue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository employeeService;

        public EmployeesController(IEmployeeRepository service)
        {
            employeeService = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            return Ok(await employeeService.GetEmployeesAsync());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetEmployee(int employeeId)
        {
            if (employeeId == 0)
            {
                return BadRequest("Invalid Employee ID");
            }
            return Ok(await employeeService.GetEmployeeAsync(employeeId));

        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee newEmployee)
        {
            if (newEmployee == null)
            {
                return BadRequest("The provided Employee is null");
            }
             await employeeService.AddEmployeeAsync(newEmployee);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteEmployee(Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("The provided Employee is null");
            }
            employeeService.DeleteEmployee(employee);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("The provided Employee is null"); 
            }
            employeeService.UpdateEmployee(employee);
            return Ok();
        }

    }
}
