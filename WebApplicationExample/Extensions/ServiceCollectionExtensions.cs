using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Security.Principal;

namespace WebApplicationExample.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static TSetting BindSection<TSetting>(this IServiceCollection services, IConfiguration configuration) where TSetting : class, new()
        {
            var settings = new TSetting();
            string sectionName = settings.GetType().Name;

            configuration.GetSection(sectionName).Bind(settings);
            services.AddSingleton(provider => settings);

            return settings;
        }

        public static TSetting BindSection<TSetting>(this IServiceCollection services, IConfiguration configuration, string sectionName) where TSetting : class, new()
        {
            var settings = new TSetting();

            configuration.GetSection(sectionName).Bind(settings);
            services.AddSingleton(provider => settings);

            return settings;
        }
    }
}
