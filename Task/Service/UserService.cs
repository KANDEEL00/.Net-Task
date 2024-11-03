using AutoMapper;
using FluentValidation;
using Task.Data;
using Task.Data.DTOs;
using Task.Data.Entities;

namespace Task.Service
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IValidator<UserDTO> _validator;

        public UserService(AppDbContext dbContext, IMapper mapper, IValidator<UserDTO> validator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<int> RegisterUser(UserDTO userDto)
        {
            var validationResult = await _validator.ValidateAsync(userDto);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var user = _mapper.Map<User>(userDto);
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            return user.UserID;
        }
    }
}
