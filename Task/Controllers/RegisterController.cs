using Microsoft.AspNetCore.Mvc;
using Task.Data.DTOs;
using Task.Service;

namespace Task.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : ControllerBase
    {
        private readonly IUserService _userService;

        public RegisterController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<int>> CreateUser(UserDTO userDto)
        {
            var userId = await _userService.RegisterUser(userDto);
            return Ok(userId);
        }
    }
}
