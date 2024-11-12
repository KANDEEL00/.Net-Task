using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RegistrationFormApi.Application.Features.User.Commands.Create;
using System.Reflection;

namespace RegistrationFormApi.Application
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CreateUserCommandHandler).GetTypeInfo().Assembly));
        }
    }
}