using MediatR;
using Microsoft.AspNetCore.Mvc;
using RegistrationFormApi.Application.Features.Governates.Queries;
using RegistrationFormApi.Application.Interfaces.Repository;

namespace RegistrationFormApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GovernateController : ControllerBase
    {
        private readonly ISender _sender;

        public GovernateController(IUserRepository userRepository, ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var governateDtos = await _sender.Send(new GovernateQuery());
            return Ok(governateDtos);
        }

    }
}
