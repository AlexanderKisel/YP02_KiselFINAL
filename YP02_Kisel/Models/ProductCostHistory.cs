﻿using System;
using System.Collections.Generic;

namespace YP02_Kisel.Models
{
    public partial class ProductCostHistory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime ChangeDate { get; set; }
        public decimal CostValue { get; set; }

        public virtual Product Product { get; set; } = null!;
    }
}
