﻿using System;
using System.Collections.Generic;

namespace YP02_Kisel.Models
{
    public partial class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public double DefectedPercent { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
