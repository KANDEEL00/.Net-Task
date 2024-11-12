using Task.API.Middlewares;

namespace Task.API.Extensions
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
            throw new System.NotImplementedException();
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}