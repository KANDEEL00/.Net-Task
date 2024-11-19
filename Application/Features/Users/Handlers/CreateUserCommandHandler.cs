using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using RegistrationFormApi.Application.Features.Users.Commands;
using RegistrationFormApi.Application.Features.Users.DTOs;
using RegistrationFormApi.Application.Interfaces.Repository;
using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Application.Features.Users.Handlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<UserDto> _validator;
        private readonly ILogger<CreateUserCommandHandler> _logger;
        private readonly IMapper _mapper;

        public CreateUserCommandHandler(IUnitOfWork unitOfWork, IValidator<UserDto> validator, ILogger<CreateUserCommandHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling CreateUserCommand for User: {UserName}", request.UserDto.FirstName);

            var validationResult = await _validator.ValidateAsync(request.UserDto);
            if (!validationResult.IsValid)
            {
                _logger.LogError("Validation exception occurred while creating user. Errors: {Errors}", validationResult.Errors);
                throw new ValidationException(validationResult.Errors);
            }

            var userDto = request.UserDto;
            var user = _mapper.Map<User>(userDto);
            user = _unitOfWork.UserRepository.Create(user);
            _unitOfWork.Save();

            _logger.LogInformation("Successfully created User with ID: {UserId}", user.UserID);

            return user.UserID;
        }
    }
}
