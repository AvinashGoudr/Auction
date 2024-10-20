using Auction.Services.Abstractions;
using Auction.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Auction.Services.Configuration
{
    public static class ServiceConfigurations
    {
        public static IServiceCollection ServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductService,ProductService>();
            return services;
        }
    }
}
