using System;
using Magelan.Repositories.DbContexts;
using Magelan.Repositories.Interfaces;
using Magelan.Repositories.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Internal;

namespace Magelan.Repositories {
    public static class RepositoryExtensions {
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services,
            IConfiguration configuration) {
            services.AddApplicationDbContext("Server=localhost;Database=Magelan;User=username;Password=password;");
            //configuration.GetConnectionString("DefaultConnection")
            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, string connectionString) {
            services.AddDbContext<MagelanDbContext>(options =>
                options.UseMySql(connectionString,
                    mySqlOptions => { mySqlOptions.ServerVersion(new Version(10, 3, 15), ServerType.MariaDb); }
                    )
                );


            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services.AddScoped<IPostRepository, PostsRepository>();

            return services;
        }
    }
}