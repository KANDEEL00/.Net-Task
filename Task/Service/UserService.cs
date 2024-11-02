using AutoMapper;
using Task.Data;
using Task.Data.DTOs;
using Task.Data.Entities;

namespace Task.Service
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public UserService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<int> RegisterUser(UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            return user.UserID;
        }
    }
}
