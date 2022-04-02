using Microsoft.AspNetCore.Mvc;
using Product.Microservice.DataOperation;

namespace Product.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_productRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Add([FromBody] DataOperation.Product product)
        {
            _productRepository.Add(product);
            return Ok();
        }
    }
}
