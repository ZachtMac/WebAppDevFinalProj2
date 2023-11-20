using System.ComponentModel;
using System.Text.Json.Serialization;

namespace BagelzModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
        
        public string? Address { get; set; }
        
        public string? City { get; set; }
        
        public string? State { get; set; }
        
        public string? PostalCode { get; set; }
        
        public string? Country { get; set; }

        [DisplayName("Customer Name")]
        [JsonIgnore]
        public string FullName => $"{LastName}, {FirstName}";

        public override string ToString() => FullName;
    }
}
