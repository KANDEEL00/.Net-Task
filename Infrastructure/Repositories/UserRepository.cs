using AutoMapper;
using RegistrationFormApi.Application.Dto;
using RegistrationFormApi.Application.Interfaces.Repository;
using RegistrationFormApi.Domain.Entities;
using RegistrationFormApi.Persistence;

namespace RegistrationFormApi.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public UserRepository(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<int> Create(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            return user.UserID;
        }
    }
}
