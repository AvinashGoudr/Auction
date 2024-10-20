using Auction.Repository.Abstractions;
using Auction.Repository.Implementations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Repository.RepositoryConfiguration
{
    public static class RespositoryConfigurations
    {
        public static IServiceCollection RespositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
