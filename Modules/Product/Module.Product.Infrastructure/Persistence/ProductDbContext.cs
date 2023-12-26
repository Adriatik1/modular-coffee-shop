using Microsoft.EntityFrameworkCore;
using Module.Product.Core.Abstractions;
using Module.Product.Core.Entities;
using Shared.Infrastructure.Persistence;

namespace Module.Product.Infrastructure.Data
{
    public class ProductDbContext : ModuleDbContext, IProductDbContext
    {
        protected override string Schema => "Product";
        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProductCategoryEntity> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
