﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;

namespace BagelzClassLibrary.Entities
{
    [Table("Customers")]

    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
        
        public string? Address { get; set; }
        
        public string? City { get; set; }
        
        public string? State { get; set; }

        [DisplayName("Zip Code")]
        public string? PostalCode { get; set; }
        
        public string? Country { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
