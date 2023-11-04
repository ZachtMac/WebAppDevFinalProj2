using BagelzClassLibrary.Data;
using Microsoft.EntityFrameworkCore;

namespace BagelzWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<BagelzContext>(optionsBuilder =>
            {
                optionsBuilder.UseSqlite(builder.Configuration.GetConnectionString("Default"));
            });

            builder.Services.AddControllers();


            builder.Services.AddCors(options =>
            {
                options.AddPolicy("CorsAllowAll",
                    policy =>
                    {
                        policy
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                    }
                );
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors("CorsAllowAll");


            app.MapControllers();

            app.Run();
        }
    }
}