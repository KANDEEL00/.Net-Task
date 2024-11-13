using MediatR;
using RegistrationFormApi.Application.Dto;

namespace RegistrationFormApi.Application.Features.Governates.Queries
{
    public class GovernateQuery : IRequest<List<GovernateDto>>
    {
    }
}
