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
        public DbSet<OrderItem> OrderLineItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { Id = 1, Name = "White Bagel", Price = 2m },
                new MenuItem { Id = 2, Name = "Everything Bagel", Price = 3m },
                new MenuItem { Id = 3, Name = "Whole Wheat Bagel", Price = 3m },
                new MenuItem { Id = 4, Name = "Cream Cheese", Price = 1m },
                new MenuItem { Id = 5, Name = "BB Cream Cheese", Price = 2m },
                new MenuItem { Id = 6, Name = "Cheese", Price = 1m },
                new MenuItem { Id = 7, Name = "Jalapeno Peppers", Price = 1m },
                new MenuItem { Id = 8, Name = "Pepper", Price = 1m },
                new MenuItem { Id = 9, Name = "Honey", Price = 1m },
                new MenuItem { Id = 10, Name = "Bacon", Price = 2m },
                new MenuItem { Id = 11, Name = "Egg", Price = 2m },
                new MenuItem { Id = 12, Name = "Tomato", Price = 1m },
                new MenuItem { Id = 13, Name = "Avacado", Price = 2m },
                new MenuItem { Id = 14, Name = "Coffee", Price = 2m },
                new MenuItem { Id = 15, Name = "Pop", Price = 3m },
                new MenuItem { Id = 16, Name = "Tea", Price = 2m },
                new MenuItem { Id = 17, Name = "Water", Price = 0m }

                );

        }
    }
}
