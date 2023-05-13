using Microsoft.EntityFrameworkCore;

namespace CrudWithApi.Model
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext> options) : base(options)
        {
        }
        public DbSet<Brand> Brand { get; set; }
    }
}
