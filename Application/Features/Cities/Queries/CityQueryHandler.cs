using MediatR;
using RegistrationFormApi.Application.Dto;
using RegistrationFormApi.Application.Interfaces.Repository;

namespace RegistrationFormApi.Application.Features.Cities.Queries
{
    public class CityQueryHandler : IRequestHandler<CityQuery, List<CityDto>>
    {
        private readonly ICityRepository _cityRepository;
        public CityQueryHandler(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public async Task<List<CityDto>> Handle(CityQuery request, CancellationToken cancellationToken)
        {
            return await _cityRepository.GetCitiesOfGovernate(request.GovernateID);
        }
    }
}
