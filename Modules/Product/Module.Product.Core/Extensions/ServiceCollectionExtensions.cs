using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Module.Product.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddProductCore(this IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
