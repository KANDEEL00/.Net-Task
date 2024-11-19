using MediatR;
using RegistrationFormApi.Application.Features.Governates.DTOs;

namespace RegistrationFormApi.Application.Features.Governates.Queries
{
    public class GovernateQuery : IRequest<List<GovernateDto>>
    {
    }
}
