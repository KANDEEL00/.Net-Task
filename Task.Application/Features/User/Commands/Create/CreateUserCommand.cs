using MediatR;
using RegistrationFormApi.Application.Dto;

namespace RegistrationFormApi.Application.Features.User.Commands.Create
{
    public class CreateUserCommand : IRequest<int>
    {
        public required UserDto UserDto { get; set; }

    }
}
