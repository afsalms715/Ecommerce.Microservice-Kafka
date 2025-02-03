using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.ProductService.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { CreatedDate = DateTime.UtcNow, Name = "Crocs", Price = 1750, Status = true, Stock = 20 });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { CreatedDate = DateTime.UtcNow, Name = "Nike", Price = 1750, Status = true, Stock = 30 });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { CreatedDate = DateTime.UtcNow, Name = "Adidas", Price = 1750, Status = true, Stock = 10 });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { CreatedDate = DateTime.UtcNow, Name = "NewBalance", Price = 1750, Status = true, Stock = 4 });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ProductModel> Products { get; set; }
    }
}
