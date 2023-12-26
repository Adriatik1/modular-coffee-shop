using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Customer.Core.Abstractions;
using Module.Customer.Infrastructure.Persistence;
using Shared.Infrastructure.Extensions;

namespace Module.Customer.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomerModuleInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddModuleDbContext<CustomerDbContext>(config)
                .AddScoped<ICustomersDbContext>(provider => provider.GetService<CustomerDbContext>()!);

            return services;
        }
    }
}
