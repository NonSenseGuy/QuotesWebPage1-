using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Quotes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host=CreateWebHostBuilder(args).Build();
            using(var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<Models.QuotesContext>();
                    context.Database.Migrate();
                    Models.SeedData.Initialize(services);
                }catch(Exception e)
                {
                    var log = services.GetRequiredService<ILogger<Program>>();
                    log.LogError(e,"Falla en carga de base de datos");
                }
            }
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
