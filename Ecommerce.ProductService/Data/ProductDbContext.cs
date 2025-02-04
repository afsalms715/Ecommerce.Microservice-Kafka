using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.ProductService.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 1, CreatedDate = new DateTime(2021, 1, 1), Name = "Crocs", Price = 1750, Status = true, Stock = 20 });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 2, CreatedDate = new DateTime(2021, 1, 1), Name = "Nike", Price = 1790, Status = true, Stock = 30 });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 3, CreatedDate = new DateTime(2021, 1, 1), Name = "Adidas", Price = 1650, Status = true, Stock = 10 });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 4, CreatedDate = new DateTime(2021, 1, 1), Name = "NewBalance", Price = 2750, Status = true, Stock = 4 });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ProductModel> Products { get; set; }
    }
}
