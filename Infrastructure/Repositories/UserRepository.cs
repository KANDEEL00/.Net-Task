using RegistrationFormApi.Application.Interfaces.Repository;
using RegistrationFormApi.Domain.Entities;
using RegistrationFormApi.Infrastructure.DB;

namespace RegistrationFormApi.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;
        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User Create(User user)
        {
            _dbContext.Users.Add(user);
            return user;
        }
    }
}
