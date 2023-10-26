using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagelzRegisterClassLibrary.Data
{
    internal class BagelzContextDesignTimeFactory : IDesignTimeDbContextFactory<BagelzContext>
    {
        public BagelzContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var optionsBuilder = new DbContextOptionsBuilder<BagelzContext>();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("dev"));

            return new BagelzContext(optionsBuilder.Options);
        }
    }
}
