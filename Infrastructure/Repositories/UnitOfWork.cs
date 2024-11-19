using RegistrationFormApi.Application.Interfaces.Repository;
using RegistrationFormApi.Infrastructure.DB;

namespace RegistrationFormApi.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IUserRepository _userRepo;
        private IGovernateRepository _governateRepo;
        private ICityRepository _cityRepository;
        private readonly AppDbContext _dbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepo == null)
                {
                    _userRepo = new UserRepository(_dbContext);
                }
                return _userRepo;
            }
        }

        public IGovernateRepository GovernateRepository
        {
            get
            {
                if (_governateRepo == null)
                {
                    _governateRepo = new GovernateRepository(_dbContext);
                }
                return _governateRepo;
            }
        }

        public ICityRepository CityRepository
        {
            get
            {
                if (_cityRepository == null)
                {
                    _cityRepository = new CityRepository(_dbContext);
                }
                return _cityRepository;
            }
        }

        public void Save() => _dbContext.SaveChanges();

    }
}
