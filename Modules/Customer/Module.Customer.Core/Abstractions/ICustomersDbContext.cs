using Microsoft.EntityFrameworkCore;
using Module.Customer.Core.Entities;

namespace Module.Customer.Core.Abstractions
{
    public interface ICustomersDbContext
    {
        public DbSet<CustomerEntity> Customers { get; set; }
    }
}
