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
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CityQueryHandler> _logger;
        private readonly IMapper _mapper;

        public CityQueryHandler(IUnitOfWork unitOfWork, ILogger<CityQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        public Task<List<CityDto>> Handle(CityQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling CityQuery for GovernateID: {GovernateID}", request.GovernateID);

            try
            {
                var cities = _unitOfWork.CityRepository.GetCitiesOfGovernate(request.GovernateID);
                _logger.LogInformation("Successfully retrieved {Count} cities for GovernateID: {GovernateID}", cities.Count, request.GovernateID);
                return Task.FromResult(_mapper.Map<List<CityDto>>(cities));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving cities for GovernateID: {GovernateID}", request.GovernateID);
                throw;
            }
        }
    }
}
