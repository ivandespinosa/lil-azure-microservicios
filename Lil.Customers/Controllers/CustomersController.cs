using Lil.Customers.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lil.Customers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersProvider _customerProvider;

        public CustomersController(ICustomersProvider customerProvider)
        {
            _customerProvider = customerProvider;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {
            var customer = await _customerProvider.GetAsync(id); ;

            if(customer != null)
            {
                return Ok(customer);
            }

            return NotFound();
        }
    }
}
