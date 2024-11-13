using AutoMapper;
using RegistrationFormApi.Application.Dto;
using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();

            CreateMap<AddressDto, Address>();
            CreateMap<Address, AddressDto>();

            CreateMap<CityDto, City>();
            CreateMap<City, CityDto>();

            CreateMap<Governate, GovernateDto>();
            CreateMap<GovernateDto, Governate>();

            CreateMap<GovernateUserCountDto, GovernateUserCount>();
            CreateMap<GovernateUserCount, GovernateUserCountDto>();
        }
    }

}
