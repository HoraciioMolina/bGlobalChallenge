using bGlobalChallgenge.Domain.Repository;
using bGlobalChallgenge.Domain.Services;
using bGlobalChallgenge.Persistence.Context;
using bGlobalChallgenge.Persistence.Repository;
using bGlobalChallgenge.Services;
using Microsoft.Extensions.DependencyInjection;

namespace bGlobalChallgenge.IoC
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddConfigurationServices(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>();

            services.AddTransient<IVehicleServices, VehicleServices>();
            services.AddTransient<IBrandServices, BrandServices>();

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            return services;
        }
    }
}
