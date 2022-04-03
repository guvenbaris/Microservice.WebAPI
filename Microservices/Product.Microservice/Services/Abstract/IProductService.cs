using System.Collections.Generic;

namespace Product.Microservice.Services.Abstract
{
    public interface IProductService
    {
        void Create(Entities.Product entity);
        void Update(Entities.Product entity);
        void Delete(int id);
        List<Entities.Product> GetAll();
        Entities.Product GetById(int id);

    }
}
