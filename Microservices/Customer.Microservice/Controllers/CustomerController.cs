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
        public IActionResult GetAll()
        {
            return Ok(_customerService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            return Ok(_customerService.GetById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] Entities.Customer customer)
        {
            _customerService.Create(customer);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] Entities.Customer customer)
        {
            _customerService.Update(customer);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Entities.Customer customer)
        {
            _customerService.Delete(customer);
            return Ok();
        }
    }
}


