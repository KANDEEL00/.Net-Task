using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RegistrationFormApi.Application.Dto;
using RegistrationFormApi.Application.Interfaces.Repository;
using RegistrationFormApi.Persistence;

namespace RegistrationFormApi.Infrastructure.Repositories
{
    public class GovernateRepository : IGovernateRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public GovernateRepository(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<GovernateDto>> GetAll()
        {
            var governates = await _dbContext.Governates.ToListAsync();
            return _mapper.Map<List<GovernateDto>>(governates);
        }
    }
}
