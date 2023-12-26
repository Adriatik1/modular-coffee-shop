﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Product.Core.Entities
{
    public class ProductCategoryEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public ICollection<ProductEntity> Products { get; set;  } = new List<ProductEntity>();
    }
}
