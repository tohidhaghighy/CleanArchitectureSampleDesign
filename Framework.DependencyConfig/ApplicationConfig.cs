using LTMS.Domain.Service;
using LTMS.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CleanArchitectureSampleDesing.Domain.Service;
using CleanArchitectureSampleDesing.Infrastructure.Persistance.Repository;
using System.Reflection;


namespace Framework.DependencyConfig
{
    public class ApplicationConfig
    {
        public static ServiceProvider DoConfig(IServiceCollection services, IConfiguration configuration)
        {
            var connStr = configuration.GetConnectionString("CleanArchitectureSampleDesingConnection");
            services.AddDbContext<CleanArchitectureSampleDesingDbContext>(o => o.UseSqlServer(connStr));

            //services.RegisterAssemblyTypes(typeof(ISampleTypeRepository).Assembly)
            //    .Where(t => t.Name.EndsWith("Repository")
            //                && t.GetInterfaces()
            //                    .Any(ti => ti.Name == typeof(ISampleTypeRepository).Name))
            //    .AsScoped()
            //    .PropertiesAutowired()
            //    .Bind();
            //


            //uncomment below when we had repository
            services.Scan(scan => scan
                .FromAssemblies(typeof(ItemCatagoryRepository).GetTypeInfo().Assembly)
                .AddClasses()
                .AsImplementedInterfaces()
                .WithScopedLifetime());

            services.Scan(scan => scan
                .FromAssemblies(typeof(ItemCatagoryService).GetTypeInfo().Assembly)
                .AddClasses()
                .AsImplementedInterfaces()
                .WithScopedLifetime());

            //services.RegisterAssemblyTypes(typeof(ISampleTypeService).Assembly)
            //    .Where(t => t.Name.EndsWith("Service")
            //                && t.GetInterfaces()
            //                    .Any(ti => ti.Name == typeof(ISampleTypeService).Name))
            //    .AsScoped()    
            //    .PropertiesAutowired()                 
            //    .Bind();

           return services.BuildServiceProvider();
        }
    }
}
