using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using RegistrationFormApi.Application.Features.Governates.DTOs;
using RegistrationFormApi.Application.Features.Governates.Queries;
using RegistrationFormApi.Application.Interfaces.Repository;

namespace RegistrationFormApi.Application.Features.Governates.Handlers
{
    public class GovernateQueryHandler : IRequestHandler<GovernateQuery, List<GovernateDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GovernateQueryHandler> _logger;
        private readonly IMapper _mapper;

        public GovernateQueryHandler(IUnitOfWork unitOfWork, ILogger<GovernateQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        public Task<List<GovernateDto>> Handle(GovernateQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GovernateQuery");

            try
            {
                var governates = _unitOfWork.GovernateRepository.GetAll();
                _logger.LogInformation("Successfully retrieved {Count} governates", governates.Count);
                return Task.FromResult(_mapper.Map<List<GovernateDto>>(governates));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving governates");
                throw;
            }
        }
    }
}
