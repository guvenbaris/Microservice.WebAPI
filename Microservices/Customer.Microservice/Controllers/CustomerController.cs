using Customer.Microservice.DataOperations;
using Microsoft.AspNetCore.Mvc;

namespace Customer.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_customerRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_customerRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Add([FromBody] DataOperations.Customer customer)
        {
            _customerRepository.Add(customer);
            return Ok();
        }
    }
}
