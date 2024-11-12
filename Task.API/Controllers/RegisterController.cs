using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RegistrationFormApi.Application.Dto;
using RegistrationFormApi.Application.Interfaces.Repository;

namespace RegistrationFormApi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : ControllerBase
    {
        private readonly IUserRepository _userService;
        private readonly ISender _sender;

        public RegisterController(IUserRepository userService, ISender sender)
        {
            _userService = userService;
            _sender = sender;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<int>> CreateUser(UserDto userDto)
        {
            try
            {
                var userId = await _userService.CreateUser(userDto);
                return Ok(userId);
            }
            catch (ValidationException ex)
            {
                var arr = ex.Errors.Select(x => $"{Environment.NewLine} -- {x.PropertyName}: {x.ErrorMessage}");
                var str = "Validation failed: " + string.Join(string.Empty, arr);
                return BadRequest(str);
            }
        }

        //public async Task<ActionResult<int>> CreateUser(CreateUserCommand command)
        //{
        //    await _sender.Send(command);
        //    return Created();
        //}
    }
}
