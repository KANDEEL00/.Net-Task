using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using RegistrationFormApi.Application.Features.Cities.DTOs;
using RegistrationFormApi.Application.Features.Cities.Queries;
using RegistrationFormApi.Application.Interfaces.Repository;

namespace RegistrationFormApi.Application.Features.Cities.Handlers
{
    public class CityQueryHandler : IRequestHandler<CityQuery, List<CityDto>>
    {
        private readonly ICityRepository _cityRepository;
        private readonly ILogger<CityQueryHandler> _logger;
        private readonly IMapper _mapper;

        public CityQueryHandler(ICityRepository cityRepository, ILogger<CityQueryHandler> logger, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<List<CityDto>> Handle(CityQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling CityQuery for GovernateID: {GovernateID}", request.GovernateID);

            try
            {
                var cities = await _cityRepository.GetCitiesOfGovernate(request.GovernateID);
                _logger.LogInformation("Successfully retrieved {Count} cities for GovernateID: {GovernateID}", cities.Count, request.GovernateID);
                return _mapper.Map<List<CityDto>>(cities);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving cities for GovernateID: {GovernateID}", request.GovernateID);
                throw;
            }
        }
    }
}
