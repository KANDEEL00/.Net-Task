using MediatR;
using RegistrationFormApi.Application.Dto;

namespace RegistrationFormApi.Application.Features.User.Queries.Governates
{
    public class GovernateQuery : IRequest<List<GovernateDto>>
    {
    }
}
