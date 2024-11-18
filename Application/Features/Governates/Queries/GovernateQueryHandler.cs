﻿using MediatR;
using Microsoft.Extensions.Logging;
using RegistrationFormApi.Application.Dto;
using RegistrationFormApi.Application.Interfaces.Repository;

namespace RegistrationFormApi.Application.Features.Governates.Queries
{
    public class GovernateQueryHandler : IRequestHandler<GovernateQuery, List<GovernateDto>>
    {
        private readonly IGovernateRepository _governateRepository;
        private readonly ILogger<GovernateQueryHandler> _logger;

        public GovernateQueryHandler(IGovernateRepository governateRepository, ILogger<GovernateQueryHandler> logger)
        {
            _governateRepository = governateRepository;
            _logger = logger;
        }

        public async Task<List<GovernateDto>> Handle(GovernateQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GovernateQuery");

            try
            {
                var governates = await _governateRepository.GetAll();
                _logger.LogInformation("Successfully retrieved {Count} governates", governates.Count);
                return governates;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving governates");
                throw;
            }
        }
    }
}
