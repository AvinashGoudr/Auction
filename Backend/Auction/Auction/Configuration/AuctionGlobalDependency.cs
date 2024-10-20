using Auction.Repository.RepositoryConfiguration;
using Auction.Services.Configuration;

namespace Auction.Configuration
{
    public static class AuctionGlobalDependency
    {
        public static IServiceCollection GlobalDependency(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.ServiceDependency();
            return services;
        }
    }
}
