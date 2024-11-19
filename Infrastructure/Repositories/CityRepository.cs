using RegistrationFormApi.Application.Interfaces.Repository;
using RegistrationFormApi.Domain.Entities;
using RegistrationFormApi.Infrastructure.DB;

namespace RegistrationFormApi.Infrastructure.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly AppDbContext _dbContext;

        public CityRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<City> GetCitiesOfGovernate(int GovernateID)
        {
            var cities = _dbContext.Cities.Where(c => c.GovernateID == GovernateID).ToList();
            return cities;
        }
    }
}
