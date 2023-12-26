using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Product.Core.Extensions;
using Module.Product.Infrastructure;

namespace Module.Product.Extensions
{
    public static class Module
    {
        public static IServiceCollection AddProductModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddProductCore()
                .AddProductModuleInfrastructure(configuration);

            return services;
        }
    }
}
