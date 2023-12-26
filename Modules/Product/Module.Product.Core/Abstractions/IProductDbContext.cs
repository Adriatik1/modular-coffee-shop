using Microsoft.EntityFrameworkCore;
using Module.Product.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Product.Core.Abstractions
{
    public interface IProductDbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProductCategoryEntity> ProductCategories { get; set; }
    }
}
