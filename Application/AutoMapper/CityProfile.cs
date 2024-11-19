using AutoMapper;
using RegistrationFormApi.Application.Features.Cities.DTOs;
using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Application.AutoMapper
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<CityDto, City>();
            CreateMap<City, CityDto>();
        }
    }
}
