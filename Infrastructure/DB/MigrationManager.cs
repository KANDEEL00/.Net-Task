using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace RegistrationFormApi.Infrastructure.DB
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
                        Log.Information("Database migration completed successfully.");
                    }
                    catch (Exception ex)
                    {
                        Log.Error(ex, "Database migration failed.");
                        throw;
                    }
                }
            }
            return webApp;
        }
    }
}
