﻿using FluentValidation;

namespace Task.Data.DTOs
{
    public class AddressDTO
    {
        public int GovernateID { get; set; }
        public int CityID { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public int FlatNumber { get; set; }
    }

    public class AddressDtoValidator : AbstractValidator<AddressDTO>
    {
        public AddressDtoValidator()
        {
            // GovernateID validation (required and positive)
            RuleFor(x => x.GovernateID)
                .GreaterThan(0).WithMessage("Governate ID must be a positive integer.");

            // CityID validation (required and positive)
            RuleFor(x => x.CityID)
                .GreaterThan(0).WithMessage("City ID must be a positive integer.");

            // Street validation (required, max length)
            RuleFor(x => x.Street)
                .NotEmpty().WithMessage("Street is required.")
                .MaximumLength(100).WithMessage("Street must not exceed 100 characters.");

            // BuildingNumber validation (positive integer, required)
            RuleFor(x => x.BuildingNumber)
                .GreaterThan(0).WithMessage("Building Number must be a positive integer.");

            // FlatNumber validation (positive integer, required)
            RuleFor(x => x.FlatNumber)
                .GreaterThan(0).WithMessage("Flat Number must be a positive integer.");
        }
    }
}