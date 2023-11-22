using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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

        [JsonIgnore]
        public decimal TaxRate { get; set; } = 0.08m;

        [JsonIgnore]
        public decimal Tax => TotalPrice * TaxRate;

        [JsonIgnore]
        public decimal TotalPrice => OrderItems.Sum(oi => oi.TotalPrice);

        [JsonIgnore]
        public string FormattedTotalPrice => String.Format("{0:C}", TotalPrice);

        [JsonIgnore]
        public string OrderItemsReadable => OrderItems.ToList().Select(oi => oi.MenuItem?.Name ?? "Error").Aggregate((a, b) => $"{a}, {b}");
    }
}
