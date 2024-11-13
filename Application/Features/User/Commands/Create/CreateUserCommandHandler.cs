using FluentValidation;
using MediatR;
using RegistrationFormApi.Application.Dto;
using RegistrationFormApi.Application.Interfaces.Repository;

namespace RegistrationFormApi.Application.Features.User.Commands.Create
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _userRepository;
        private readonly IValidator<UserDto> _validator;
        public CreateUserCommandHandler(IUserRepository userRepository, IValidator<UserDto> validator)
        {
            _userRepository = userRepository;
            _validator = validator;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request.UserDto);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var userDto = request.UserDto;
            return await _userRepository.Create(userDto);
        }
    }
}
