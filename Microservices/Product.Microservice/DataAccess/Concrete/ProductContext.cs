using Microsoft.EntityFrameworkCore;

namespace Product.Microservice.DataAccess.Concrete
{
    public class ProductContext :DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) :base(options)
        {
            
        }
        public DbSet<Entities.Product> Products { get; set; }
    }
}