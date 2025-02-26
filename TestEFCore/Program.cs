using Microsoft.EntityFrameworkCore;
using TestEFCore.Service.Models;
using TestEFCore.Service.Interfaces;
using TestEFCore.Service.Services;

namespace TestEFCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            builder.Services.AddDbContext<RdErpV1Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")
                //可設定相關參數，例如Command Timeout,etc.
                //,providerOptions=> providerOptions.CommandTimeout(60)
                ));

            builder.Services.AddScoped<ISysNoticesService, SysNoticesService>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}