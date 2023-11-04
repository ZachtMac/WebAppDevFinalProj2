using System.ComponentModel;

namespace BagelzModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
        
        [DisplayName("Customer Name")]
        public string FullName => $"{LastName}, {FirstName}";
        
        public string? Address { get; set; }
        
        public string? City { get; set; }
        
        public string? State { get; set; }
        
        public string? PostalCode { get; set; }
        
        public string? Country { get; set; }
    }
}
