using FluentValidation;
using RegistrationFormApi.Application.Features.Address.DTOs;

namespace RegistrationFormApi.Application.Features.Address.Validations
{
    public class AddressDtoValidator : AbstractValidator<AddressDto>
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
                .MaximumLength(200).WithMessage("Street must not exceed 200 characters.");

            // BuildingNumber validation (required, max length)
            RuleFor(x => x.BuildingNumber)
                .NotEmpty().WithMessage("Building Number is required.")
                .MaximumLength(20).WithMessage("Building Number must not exceed 20 characters.");

            // FlatNumber validation (positive integer, required)
            RuleFor(x => x.FlatNumber)
                .GreaterThan(0).WithMessage("Flat Number must be a positive integer.");
        }
    }
}