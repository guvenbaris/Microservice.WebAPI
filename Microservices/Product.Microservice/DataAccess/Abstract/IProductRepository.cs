using System.Collections.Generic;

namespace Product.Microservice.DataAccess.Abstract
{
    public interface IProductRepository
    {
        void Create(Entities.Product entity);
        void Update(Entities.Product entity);
        void Delete(Entities.Product entity);
        List<Entities.Product> GetAll();
        Entities.Product GetById(int id);

    }
}

