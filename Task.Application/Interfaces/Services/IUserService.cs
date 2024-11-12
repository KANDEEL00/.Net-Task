using RegistrationFormApi.Application.Dto;

namespace RegistrationFormApi.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<int> RegisterUser(UserDto userDto);
    }
}