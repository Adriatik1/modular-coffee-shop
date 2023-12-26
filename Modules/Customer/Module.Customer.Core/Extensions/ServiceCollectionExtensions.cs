using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Module.Customer.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomerCore(this IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
