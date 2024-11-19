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

        public List<Governate> GetAll()
        {
            var governates = _dbContext.Governates.ToList();
            return governates;
        }
    }
}
