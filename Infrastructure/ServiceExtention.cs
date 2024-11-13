using Microsoft.Extensions.DependencyInjection;
using RegistrationFormApi.Application.Interfaces.Repository;
using RegistrationFormApi.Infrastructure.Repositories;

namespace RegistrationFormApi.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}