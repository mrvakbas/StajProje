using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contrats;
using Services.Contracts;
using Services;

namespace StajProje.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("mssqlconnection"),
                    b => b.MigrationsAssembly("StajProje"));

                options.EnableSensitiveDataLogging(true);
            });
        }

        public static void ConfigurationRepositoryRegistration(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IRickRepository, RickRepository>();
        }

        public static void ConfigurationServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IRickService, RickManager>();
        }

    }
}
