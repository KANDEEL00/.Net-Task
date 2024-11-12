using Microsoft.Extensions.DependencyInjection;
using RegistrationFormApi.Application.Interfaces.Services;
using RegistrationFormApi.Infrastructure.Services;

namespace RegistrationFormApi.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}