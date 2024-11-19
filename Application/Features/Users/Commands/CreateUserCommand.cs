using MediatR;
using RegistrationFormApi.Application.Features.Users.DTOs;

namespace RegistrationFormApi.Application.Features.Users.Commands
{
    public class CreateUserCommand : IRequest<int>
    {
        public required UserDto UserDto { get; set; }

    }
}
