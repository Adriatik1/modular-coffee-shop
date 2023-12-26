using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Customer.Infrastructure;
using Module.Customer.Core.Extensions;

namespace Module.Customer.Extensions
{
    public static class Module
    {
        public static IServiceCollection AddCustomerModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddCustomerCore()
                .AddCustomerModuleInfrastructure(configuration);

            return services;
        }
    }
}
