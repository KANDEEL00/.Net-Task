using MediatR;
using Microsoft.AspNetCore.Mvc;
using RegistrationFormApi.Application.Interfaces.Repository;

namespace RegistrationFormApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ISender _sender;
        private readonly ICityRepository _cityRepository;

        public CityController(IUserRepository userRepository, ISender sender, ICityRepository cityRepository)
        {
            _sender = sender;
            _cityRepository = cityRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCities(int GovernateID)
        {
            var cityDtos = await _cityRepository.GetCitiesOfGovernate(GovernateID);
            return Ok(cityDtos);
        }
    }
}
