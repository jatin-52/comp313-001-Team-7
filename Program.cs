using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SecondHandBook.Data;

namespace SecondHandBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Testing
            // CreateHostBuilder(args).Build().Run();
            var host = CreateHostBuilder(args).Build();
            try
            {
                using (var scope = host.Services.CreateScope())
                {
                    var serviceprovide = scope.ServiceProvider;
                    var roleManager = serviceprovide.GetRequiredService<RoleManager<IdentityRole>>();
                    DbInitializer.Seed(roleManager);
                }

                // adding img folder if not present
                string ImgSavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img");
                if (!Directory.Exists(ImgSavePath))
                {
                    Directory.CreateDirectory(ImgSavePath);
                }
            }
            catch (Exception e)
            {

            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
