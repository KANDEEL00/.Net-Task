using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RegistrationFormApi.Application.Dto;
using RegistrationFormApi.Application.Interfaces.Repository;
using RegistrationFormApi.Infrastructure.DB;

namespace RegistrationFormApi.Infrastructure.Repositories
{
    internal class CityRepository : ICityRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public CityRepository(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<CityDto>> GetCitiesOfGovernate(int GovernateID)
        {
            var cities = await _dbContext.Cities.Where(c => c.GovernateID == GovernateID).ToListAsync();
            return _mapper.Map<List<CityDto>>(cities);
        }
    }
}
