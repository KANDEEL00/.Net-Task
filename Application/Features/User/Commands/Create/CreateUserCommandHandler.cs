using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using RegistrationFormApi.Application.Dto;
using RegistrationFormApi.Application.Interfaces.Repository;

namespace RegistrationFormApi.Application.Features.User.Commands.Create
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _userRepository;
        private readonly IValidator<UserDto> _validator;
        private readonly ILogger<CreateUserCommandHandler> _logger;

        public CreateUserCommandHandler(IUserRepository userRepository, IValidator<UserDto> validator, ILogger<CreateUserCommandHandler> logger)
        {
            _userRepository = userRepository;
            _validator = validator;
            _logger = logger;
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
            var userId = await _userRepository.Create(userDto);

            _logger.LogInformation("Successfully created User with ID: {UserId}", userId);

            return userId;
        }
    }
}
