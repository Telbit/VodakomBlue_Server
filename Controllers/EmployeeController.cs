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

        [HttpDelete("id")]
        public IActionResult DeleteEmployee(int employeeId)
        {
            if (employeeId == 0)
            {
                return BadRequest("Invalid Employee ID");
            }
            Employee employee = employeeService.GetEmployeeAsync(employeeId).Result;
            if (employee != null)
            {
                employeeService.DeleteEmployee(employee);
                return Ok();
            }
            return NotFound("Employee not found with the provided Employee ID");
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
