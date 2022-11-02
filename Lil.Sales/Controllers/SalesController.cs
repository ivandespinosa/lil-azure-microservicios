﻿using Lil.Sales.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lil.Sales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISalesProvider _salesProvider;

        public SalesController(ISalesProvider salesProvider)
        {
            _salesProvider = salesProvider;
        }

        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetAsync(string customerId)
        {
            var orders = await _salesProvider.GetAsync(customerId);

            if(orders != null && orders.Any())
            {
                return Ok(orders);
            }

            return NotFound();
        }
    }
}
