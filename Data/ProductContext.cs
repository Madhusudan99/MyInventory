

using Microsoft.EntityFrameworkCore;
using MyInventory.Model;

namespace MyInventory.Data
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext>  options):  base(options)
        {

        }
        public DbSet<Product> products { get; set; }
        public DbSet<apiKey> apiKeys { get; set; }
    }
}
