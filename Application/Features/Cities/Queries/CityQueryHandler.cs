using MediatR;
using Microsoft.Extensions.Logging;
using RegistrationFormApi.Application.Dto;
using RegistrationFormApi.Application.Interfaces.Repository;

namespace RegistrationFormApi.Application.Features.Cities.Queries
{
    public class CityQueryHandler : IRequestHandler<CityQuery, List<CityDto>>
    {
        private readonly ICityRepository _cityRepository;
        private readonly ILogger<CityQueryHandler> _logger;

        public CityQueryHandler(ICityRepository cityRepository, ILogger<CityQueryHandler> logger)
        {
            _cityRepository = cityRepository;
            _logger = logger;
        }

        public async Task<List<CityDto>> Handle(CityQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling CityQuery for GovernateID: {GovernateID}", request.GovernateID);

            try
            {
                var cities = await _cityRepository.GetCitiesOfGovernate(request.GovernateID);
                _logger.LogInformation("Successfully retrieved {Count} cities for GovernateID: {GovernateID}", cities.Count, request.GovernateID);
                return cities;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving cities for GovernateID: {GovernateID}", request.GovernateID);
                throw;
            }
        }
    }
}
