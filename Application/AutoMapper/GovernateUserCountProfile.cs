using AutoMapper;
using RegistrationFormApi.Application.Dto;
using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Application.AutoMapper
{
    public class GovernateUserCountProfile : Profile
    {
        public GovernateUserCountProfile()
        {
            CreateMap<GovernateUserCountDto, GovernateUserCount>();
            CreateMap<GovernateUserCount, GovernateUserCountDto>();
        }
    }
}
