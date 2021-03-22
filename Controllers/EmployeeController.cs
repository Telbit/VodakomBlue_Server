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
                return BadRequest();
            }
            return Ok(await employeeService.GetEmployeeAsync(employeeId));

        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee newEmployee)
        {
            if (newEmployee == null)
            {
                return BadRequest();
            }
             await employeeService.AddEmployeeAsync(newEmployee);
            return Ok();
        }

        [HttpDelete("id")]
        public IActionResult DeleteEmployee(int employeeId)
        {
            if (employeeId == 0)
            {
                return BadRequest();
            }
            employeeService.DeleteEmployee(employeeId);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {
            if (employee == null)
            {
                return BadRequest(); 
            }
            employeeService.UpdateEmployee(employee);
            return Ok();
        }

    }
}
