using Microsoft.EntityFrameworkCore;
using Module.Customer.Core.Abstractions;
using Module.Customer.Core.Entities;
using Shared.Infrastructure.Persistence;

namespace Module.Customer.Infrastructure.Persistence
{
    public class CustomerDbContext : ModuleDbContext, ICustomersDbContext
    {
        protected override string Schema => "Customer";
        public CustomerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CustomerEntity> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
