using AutoMapper;
using Task.Application.Dto;
using Task.Domain.Entities;

namespace Task.Application.Mappings
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
