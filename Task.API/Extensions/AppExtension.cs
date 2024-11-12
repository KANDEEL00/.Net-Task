using RegistrationFormApi.API.Middlewares;

namespace RegistrationFormApi.API.Extensions
{
    public static class AppExtensions
    {
        public static void UseSwaggerExtension(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Registration.API");
            });
        }
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            throw new NotImplementedException();
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}