using ikvm.runtime;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace eTickets
{
    public class Program    
    {
        public static void Main(string[] args)
        {
            // Set the ServerCertificateValidationCallback property before building the web host.



            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<eTickets.Data.AppDbContext>(options => options.UseSqlServer("Data Source=DESKTOP-JBAUNF9\\SQLEXPRESS;Initial Catalog=projectdb;Integrated Security=True;Pooling=False"));
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
