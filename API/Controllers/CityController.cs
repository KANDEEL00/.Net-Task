using MediatR;
using Microsoft.AspNetCore.Mvc;
using RegistrationFormApi.Application.Features.Cities.Queries;
using RegistrationFormApi.Application.Interfaces.Repository;

namespace RegistrationFormApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ISender _sender;

        public CityController(IUserRepository userRepository, ISender sender, ICityRepository cityRepository)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetCities(int GovernateID)
        {
            var cityDtos = await _sender.Send(new CityQuery() { GovernateID = GovernateID });
            return Ok(cityDtos);
        }
    }
}
