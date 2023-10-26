using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagelzRegisterClassLibrary.Entities
{
    [Table("Orders")]
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; } = null;
        public virtual ICollection<OrderLineItem> OrderLineItems { get; set; } = new List<OrderLineItem>();

    }
}
