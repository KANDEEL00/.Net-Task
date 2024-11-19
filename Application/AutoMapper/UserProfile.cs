using AutoMapper;
using RegistrationFormApi.Application.Features.Users.DTOs;
using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Application.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();
        }
    }
}
