using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BagelzClassLibrary.Data
{
    internal class BagelzContextDesignTimeFactory : IDesignTimeDbContextFactory<BagelzContext>
    {
        public BagelzContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            
            var builder = new DbContextOptionsBuilder<BagelzContext>();

            builder.UseSqlite(configuration.GetConnectionString("Default"));

            return new BagelzContext(builder.Options);
        }
    }
}
