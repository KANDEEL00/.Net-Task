using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RegistrationFormApi.Persistence
{
    public static class MigrationManager
    {
        public static WebApplication MigrateDatabase(this WebApplication webApp)
        {
            using (var scope = webApp.Services.CreateScope())
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<AppDbContext>())
                {
                    try
                    {
                        appContext.Database.Migrate();
                        Console.WriteLine("Migration Done");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Migration Failed");
                        Console.WriteLine(ex);
                        throw;
                    }
                }
            }
            return webApp;
        }
    }
}
