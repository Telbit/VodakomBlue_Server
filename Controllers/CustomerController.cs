using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model;
using VodakomBlue.Repositories;

namespace VodakomBlue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository customerService;

        public CustomerController(ICustomerRepository service)
        {
            customerService = service;
        }

        [HttpGet("cutomerId")]
        public async Task<IActionResult> GetCustomer(Customer customer)
        {
            if (customer.Id != 0)
            {
                return Ok(await customerService.GetCustomerAsync(customer.Id));

            }
            else if (customer.ContactPhoneNumber != null)
            {
                return Ok(await customerService.GetCustomerAsync(customer.ContactPhoneNumber));

            }
            else if (customer.IdCardNumber != null && customer.FirstName != null & customer.LastName != null)
            {
                return Ok(await customerService.GetCustomerAsync(customer.IdCardNumber, customer.FirstName, customer.LastName));
            }
            return BadRequest("Customer is null");
        }

        [HttpDelete("customerId")]
        public IActionResult DeleteCustomer(int customerId)
        {
            if (customerId == 0)
            {
                return BadRequest("Invalid Customer ID");
            }
            Customer customer = customerService.GetCustomerAsync(customerId).Result;
            if (customer != null)
            {
                customerService.DeleteCustomer(customer);
                return Ok();
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customer customer)
        {

            if (customer == null)
            {
                return BadRequest("The provided Customer is null ");
            }
            await customerService.AddCustomerAsync(customer);
            return Ok();
            
        }

        [HttpPut]
        public IActionResult UpdateCustomer(Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("The provided Customer is null ");
            }
            customerService.UpdateCustomer(customer);
            return Ok();
        }
    }
}
