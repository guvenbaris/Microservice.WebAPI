using System.Collections.Generic;

namespace Product.Microservice.DataOperation
{
    public interface IProductRepository
    {
        void Add(Product entity);
        void Update(Product entity);
        List<Product> GetAll();
        Product GetById(int id);

    }
}

