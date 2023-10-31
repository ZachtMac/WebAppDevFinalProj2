﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagelzClassLibrary.Entities
{
    [Table("OrderLineItems")]
    public class OrderLineItem
    {
        public int OrderLineItemId { get; set; }
        public int MenuItemId { get; set; }
        public int OrderId { get; set; }
        public float Price { get; set; }
        public virtual MenuItem? MenuItem { get; set; } = null;
    }
}
