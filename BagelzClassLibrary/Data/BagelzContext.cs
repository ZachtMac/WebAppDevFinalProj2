using BagelzClassLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BagelzClassLibrary.Data
{
    public class BagelzContext : DbContext
    {
        public BagelzContext(DbContextOptions<BagelzContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<OrderLineItem> OrderLineItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { MenuItemId = 1, Name = "White Bagel", Price = 2 },
                new MenuItem { MenuItemId = 2, Name = "Everything Bagel", Price = 3 },
                new MenuItem { MenuItemId = 3, Name = "Whole Wheat Bagel", Price = 3 },
                new MenuItem { MenuItemId = 4, Name = "Cream Cheese", Price = 1 },
                new MenuItem { MenuItemId = 5, Name = "BB Cream Cheese", Price = 2 },
                new MenuItem { MenuItemId = 6, Name = "Cheese", Price = 1 },
                new MenuItem { MenuItemId = 7, Name = "Jalapeno Peppers", Price = 1 },
                new MenuItem { MenuItemId = 8, Name = "Pepper", Price = 1 },
                new MenuItem { MenuItemId = 9, Name = "Honey", Price = 1 },
                new MenuItem { MenuItemId = 10, Name = "Bacon", Price = 2 },
                new MenuItem { MenuItemId = 11, Name = "Egg", Price = 2 },
                new MenuItem { MenuItemId = 12, Name = "Tomato", Price = 1 },
                new MenuItem { MenuItemId = 13, Name = "Avacado", Price = 2 },
                new MenuItem { MenuItemId = 14, Name = "Coffee", Price = 2 },
                new MenuItem { MenuItemId = 15, Name = "Pop", Price = 3 },
                new MenuItem { MenuItemId = 16, Name = "Tea", Price = 2 },
                new MenuItem { MenuItemId = 17, Name = "Water", Price = 0 }

                );
        }
    }
}
