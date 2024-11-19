using MediatR;
using RegistrationFormApi.Application.Features.Cities.DTOs;

namespace RegistrationFormApi.Application.Features.Cities.Queries
{
    public class CityQuery : IRequest<List<CityDto>>
    {
        public required int GovernateID { get; set; }
    }
}
