using Microsoft.Extensions.DependencyInjection;

namespace RegistrationFormApi.Persistence
{
    public static class ServiceExtension
    {
        public static void AddPersistenceLayer(this IServiceCollection service)
        {
            service.AddDbContext<AppDbContext>();
        }
    }
}
