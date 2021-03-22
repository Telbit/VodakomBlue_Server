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
    public class ContractController : ControllerBase
    {
        private readonly IContractRepository contractService;

        public ContractController(IContractRepository service)
        {
            contractService = service;
        }

        [HttpGet("userId")]
        public async Task<IActionResult> GetContracts(int userId)
        {
            if (userId == 0)
            {
                return BadRequest();
            }
            return Ok(await contractService.GetAllContractAsync(userId));
        }

        [HttpPost]
        public async Task<IActionResult> AddContract(Contract contract)
        {
            if (contract == null)
            {
                return BadRequest();
            }
            await contractService.AddContractAsync(contract);
            return Ok();
        }
    }
}
