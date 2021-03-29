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
    public class AddressController : ControllerBase
    {

        private readonly IAddressRepository addressService;

        public AddressController(IAddressRepository service)
        {
            addressService = service;
        }

        [HttpGet("customerId")]
        public async Task<IActionResult> GetAddresses(int customerId)
        {
            if (customerId == 0)
            {
                return BadRequest("Invalid Customer ID");
            }
            return Ok(await addressService.GetAddressesAsync(customerId));
        }

        [HttpPost]
        public async Task<IActionResult> AddAddress(Address newAddress)
        {
            if (newAddress == null)
            {
                return BadRequest("The provided Address is null");
            }
            await addressService.AddAddressAsync(newAddress);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAddress(Address address)
        {
            if (address == null)
            {
                return BadRequest("The provided Address is null");
            }
            addressService.UpdateAddress(address);
            return Ok();
        }

        [HttpDelete("addressId")]
        public IActionResult DeleteAddress(int addressId)
        {
            if (addressId == 0)
            {
                return BadRequest("Invalid Address ID");
            }
            addressService.DeleteAddress(addressId);
            return Ok();
        }
    }
}
