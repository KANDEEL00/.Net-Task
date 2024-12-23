﻿using AutoMapper;
using RegistrationFormApi.Application.Features.Address.DTOs;
using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Application.AutoMapper
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressDto, Address>();
            CreateMap<Address, AddressDto>();
        }
    }
}
