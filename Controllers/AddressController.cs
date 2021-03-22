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
        public async Task<IEnumerable<Address>> GetAddresses(int customerId)
        {
            return await addressService.GetAddressesAsync(customerId);
        }

        [HttpPost]
        public async Task AddAddress(Address newAddress)
        {
            await addressService.AddAddressAsync(newAddress);
        }

        [HttpPut]
        public void UpdateAddress(Address address)
        {
            addressService.UpdateAddress(address);
        }

        [HttpDelete("addressId")]
        public void DeleteAddress(int addressId)
        {
            addressService.DeleteAddress(addressId);
        }
    }
}
