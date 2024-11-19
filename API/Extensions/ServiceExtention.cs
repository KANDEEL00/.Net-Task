using FluentValidation;
using Microsoft.OpenApi.Models;
using RegistrationFormApi.Application.AutoMapper;
using RegistrationFormApi.Application.Features.Users.Handlers;
using RegistrationFormApi.Application.Features.Users.Validations;
using RegistrationFormApi.Application.Interfaces.Repository;
using RegistrationFormApi.Infrastructure.DB;
using RegistrationFormApi.Infrastructure.Repositories;
using System.Reflection;

namespace RegistrationFormApi.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //Application Layer
            services.AddAutoMapper(typeof(UserProfile).Assembly);
            services.AddValidatorsFromAssembly(typeof(UserDtoValidator).GetTypeInfo().Assembly);
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CreateUserCommandHandler).GetTypeInfo().Assembly));

            //Infrastructure Layer
            services.AddDbContext<AppDbContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IGovernateRepository, GovernateRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
        }
        public static void AddSwaggerExtension(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Registration Form - API",
                });

            });
        }

    }
}