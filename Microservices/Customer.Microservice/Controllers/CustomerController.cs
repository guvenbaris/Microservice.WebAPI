using System.Threading.Tasks;
using Customer.Microservice.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Customer.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _customerService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _customerService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Entities.Customer customer)
        {
            await _customerService.Create(customer);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Entities.Customer customer)
        {
            await _customerService.Update(customer);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _customerService.Delete(id);
            return Ok();
        }
    }
}


