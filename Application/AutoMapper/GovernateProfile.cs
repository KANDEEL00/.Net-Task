using AutoMapper;
using RegistrationFormApi.Application.Features.Governates.DTOs;
using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Application.AutoMapper
{
    public class GovernateProfile : Profile
    {
        public GovernateProfile()
        {
            CreateMap<Governate, GovernateDto>();
            CreateMap<GovernateDto, Governate>();
        }
    }
}
