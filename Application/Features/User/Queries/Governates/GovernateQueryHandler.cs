using MediatR;
using RegistrationFormApi.Application.Dto;
using RegistrationFormApi.Application.Interfaces.Repository;

namespace RegistrationFormApi.Application.Features.User.Queries.Governates
{
    public class GovernateQueryHandler : IRequestHandler<GovernateQuery, List<GovernateDto>>
    {
        private readonly IGovernateRepository _governateRepository;
        public GovernateQueryHandler(IGovernateRepository governateRepository)
        {
            _governateRepository = governateRepository;
        }
        public async Task<List<GovernateDto>> Handle(GovernateQuery request, CancellationToken cancellationToken)
        {
            return await _governateRepository.GetAll();
        }
    }
}
