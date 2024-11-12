using RegistrationFormApi.Application.Dto;

namespace RegistrationFormApi.Application.Interfaces.Repository
{
    public interface IUserRepository
    {
        Task<int> CreateUser(UserDto userDto);
    }
}