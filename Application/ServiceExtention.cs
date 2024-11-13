using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using RegistrationFormApi.Application.Features.User.Commands.Create;
using RegistrationFormApi.Application.Mappings;
using System.Reflection;

namespace RegistrationFormApi.Application
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(typeof(MappingProfile).Assembly);
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CreateUserCommandHandler).GetTypeInfo().Assembly));
        }
    }
}