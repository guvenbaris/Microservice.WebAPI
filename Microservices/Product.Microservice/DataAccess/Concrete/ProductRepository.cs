using System.Collections.Generic;
using System.Linq;
using Product.Microservice.DataAccess.Abstract;

namespace Product.Microservice.DataAccess.Concrete
{
    public class ProductRepository :IProductRepository
    {
        private readonly ProductContext _context;
        public ProductRepository(ProductContext context)
        {
            _context = context;
        }
        public void Create(Entities.Product entity)
        {
            _context.Products.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Entities.Product entity)
        {
            _context.Products.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(Entities.Product entity)
        {
            _context.Products.Remove(entity);
            _context.SaveChanges();
        }

        public List<Entities.Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Entities.Product GetById(int id)
        {
            return _context.Products.SingleOrDefault(p => p.Id == id);
        }
    }
}