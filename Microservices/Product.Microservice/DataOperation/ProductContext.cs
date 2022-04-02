using Microsoft.EntityFrameworkCore;

namespace Product.Microservice.DataOperation
{
    public class ProductContext :DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) :base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}