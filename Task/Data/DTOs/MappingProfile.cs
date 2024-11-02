using AutoMapper;
using Task.Data.Entities;

namespace Task.Data.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDTO, User>();
            CreateMap<AddressDTO, Address>();
        }
    }

}
