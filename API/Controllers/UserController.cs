using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RegistrationFormApi.Application.Features.User.Commands.Create;
using RegistrationFormApi.Application.Interfaces.Repository;

namespace RegistrationFormApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ISender _sender;

        public UserController(IUserRepository userRepository, ISender sender)
        {
            _userRepository = userRepository;
            _sender = sender;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<int>> RegisterUser(CreateUserCommand command)
        {
            try
            {
                var userId = await _sender.Send(command);
                return Ok(userId);
            }
            catch (ValidationException ex)
            {
                var arr = ex.Errors.Select(x => $"{Environment.NewLine} -- {x.PropertyName}: {x.ErrorMessage}");
                var str = "Validation failed: " + string.Join(string.Empty, arr);
                return BadRequest(str);
            }
        }
    }
}