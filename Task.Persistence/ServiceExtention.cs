using Microsoft.Extensions.DependencyInjection;

namespace Task.Persistence
{
    public static class ServiceExtension
    {
        public static void AddPersistenceLayer(this IServiceCollection service)
        {
            service.AddDbContext<AppDbContext>();
        }
    }
}
