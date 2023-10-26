using BagelzClassLibrary.Data;
using Microsoft.EntityFrameworkCore;

namespace BagelzRegisterWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<BagelzContext>(optionsBuilder =>
            {
                optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString("dev"));
            });

            builder.Services.AddControllers();


            builder.Services.AddCors(options =>
            {
                options.AddPolicy("CorsAllowAll",
                    policy =>
                    {
                        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                    });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseCors("CorsAllowAll");

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}