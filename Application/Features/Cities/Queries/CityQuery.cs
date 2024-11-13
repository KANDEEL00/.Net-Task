using MediatR;
using RegistrationFormApi.Application.Dto;

namespace RegistrationFormApi.Application.Features.Cities.Queries
{
    public class CityQuery : IRequest<List<CityDto>>
    {
        public required int GovernateID { get; set; }
    }
}
