using Microsoft.EntityFrameworkCore;
using RegistrationFormApi.Application.Interfaces.Repository;
using RegistrationFormApi.Domain.Entities;
using RegistrationFormApi.Infrastructure.DB;

namespace RegistrationFormApi.Infrastructure.Repositories
{
    public class GovernateRepository : IGovernateRepository
    {
        private readonly AppDbContext _dbContext;

        public GovernateRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Governate>> GetAll()
        {
            var governates = await _dbContext.Governates.ToListAsync();
            return governates;
        }
    }
}
