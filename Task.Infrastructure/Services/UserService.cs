using AutoMapper;
using FluentValidation;
using RegistrationFormApi.Application.Dto;
using RegistrationFormApi.Application.Interfaces.Services;
using RegistrationFormApi.Domain.Entities;
using RegistrationFormApi.Persistence;

namespace RegistrationFormApi.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IValidator<UserDto> _validator;

        public UserService(AppDbContext dbContext, IMapper mapper, IValidator<UserDto> validator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<int> RegisterUser(UserDto userDto)
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
