using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Product.Core.Abstractions;
using Module.Product.Infrastructure.Data;
using Shared.Infrastructure.Extensions;

namespace Module.Product.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddProductModuleInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddModuleDbContext<ProductDbContext>(config)
                .AddScoped<IProductDbContext>(provider => provider.GetService<ProductDbContext>()!);

            return services;
        }
    }
}
