using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BagelzModels
{
    public class MenuItemViewModel
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }
        
        public string? Description { get; set; }
        
        public decimal Price { get; set; }

        [JsonIgnore]
        public string FormattedPrice => String.Format("{0:C}", Price);
    }
}
