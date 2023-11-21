using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(AddAppConfiguration)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static void AddAppConfiguration(
            HostBuilderContext hostingContext,
            IConfigurationBuilder configBuilder)
        {
            var currentEnvironment = hostingContext.HostingEnvironment;

            if (currentEnvironment.IsDevelopment())
            {
                configBuilder.AddUserSecrets<Startup>();
            }

            configBuilder.AddJsonFile(
                path: "appsettings.json",
                optional: true,
                reloadOnChange: true);

            configBuilder.AddEnvironmentVariables();
        }
    }
}
