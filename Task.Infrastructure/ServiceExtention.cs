using Microsoft.Extensions.DependencyInjection;
using Task.Application.Interfaces.Services;
using Task.Infrastructure.Services;

namespace Task.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}