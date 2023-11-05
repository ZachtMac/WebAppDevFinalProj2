using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagelzModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        public virtual CustomerViewModel? Customer { get; set; } = null;

        public virtual List<OrderItemViewModel> OrderItems { get; set; } = new();

        public decimal Total => OrderItems.Sum(oi => oi.Price * oi.Quantity);

        public string FormattedTotal => String.Format("{0:C}", Total);
    }
}
