using Magelan.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Magelan.Services.Extensions {
    public static class ServicesExtensions {
        public static IServiceCollection AddMagelanServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IMagelanService, MagelanService>();
            

            return services;
        }
    }
}