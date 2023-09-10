using EntityLayer.Concrete;
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
        public DbSet<Category> categories { get; set; }
        public DbSet<Menu> menus { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductAndCategory> productAndCategories { get; set; }
        public DbSet<ProductAndImage> productAndImages { get; set; }
        public DbSet<ProductAndSpecification> productAndSpecifications { get; set; }
        public DbSet<Specification> specifications { get; set; }
        public DbSet<SpecificationValue> specificationValues { get; set; }
        public DbSet<Tax> taxes { get; set; }
    }
}
