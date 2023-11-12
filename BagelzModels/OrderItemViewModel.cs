﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagelzModels
{
    public class OrderItemViewModel
    {
        public int Id { get; set; }

        public int MenuItemId { get; set; }

        public int OrderId { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public virtual MenuItemViewModel? MenuItem { get; set; } = null;
    }
}