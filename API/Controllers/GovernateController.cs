using MediatR;
using Microsoft.AspNetCore.Mvc;
using RegistrationFormApi.Application.Interfaces.Repository;

namespace RegistrationFormApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GovernateController : ControllerBase
    {
        private readonly ISender _sender;
        private readonly IGovernateRepository _governateRepository;

        public GovernateController(IUserRepository userRepository, ISender sender, IGovernateRepository governateRepository)
        {
            _sender = sender;
            _governateRepository = governateRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var governateDtos = await _governateRepository.GetAll();
            return Ok(governateDtos);
        }
        //public async Task<IActionResult> GetAll(GovernateQuery query)
        //{
        //    var governateDtos = await _sender.Send(query);
        //    return Ok(governateDtos);
        //}
    }
}
