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
            CreateMap<AddressDto, Address>();
        }
    }

}
