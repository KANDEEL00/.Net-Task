﻿using FluentValidation;
using RegistrationFormApi.Application.Features.Address.Validations;
using RegistrationFormApi.Application.Features.Users.DTOs;

namespace RegistrationFormApi.Application.Features.Users.Validations
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            // First Name validation
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First Name is required.")
                .MaximumLength(20).WithMessage("First Name must not exceed 20 characters.");

            // Middle Name validation (optional, max length only)
            RuleFor(x => x.MiddleName)
                .MaximumLength(20).WithMessage("Middle Name must not exceed 20 characters.");

            // Last Name validation
            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last Name is required.")
                .MaximumLength(20).WithMessage("Last Name must not exceed 20 characters.");

            // Birth Date validation
            RuleFor(x => x.BirthDate)
                .NotEmpty().WithMessage("Birth Date is required.")
                .LessThan(DateTime.Today).WithMessage("Birth Date must be in the past.");

            // Mobile Number validation
            RuleFor(x => x.MobileNumber)
                .NotEmpty().WithMessage("Mobile Number is required.")
                .Matches(@"^\d{10,15}$").WithMessage("Mobile Number must be between 10 and 15 digits.");

            // Email validation
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Email must be a valid email address.");

            // Addresses validation
            RuleFor(x => x.Addresses)
                .NotEmpty().WithMessage("At least one address is required.")
                .Must(addresses => addresses.All(a => a != null)).WithMessage("Address cannot be null.");

            // Nested validator for Addresses
            RuleForEach(x => x.Addresses).SetValidator(new AddressDtoValidator());
        }
    }
}
