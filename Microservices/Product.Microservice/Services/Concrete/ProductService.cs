using System.Collections.Generic;
using Product.Microservice.DataAccess.Abstract;
using Product.Microservice.Services.Abstract;

namespace Product.Microservice.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(Entities.Product entity)
        {
            _productRepository.Create(entity);
        }

        public void Update(Entities.Product entity)
        {
            _productRepository.Update(entity);
        }

        public void Delete(int id)
        {
            var product = _productRepository.GetById(id);
            _productRepository.Delete(product);
        }

        public List<Entities.Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Entities.Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }
    }
}
