using EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Concrete.Context
{
    public class ECommerceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=EMIRHAN\\SQLEXPRESS; database=MiniECommerce; Trusted_Connection=True;MultipleActiveResultSets=true; TrustServerCertificate=True;encrypt=false;");
        }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Tax> taxes { get; set; }
    }
}
