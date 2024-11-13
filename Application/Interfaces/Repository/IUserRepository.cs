using RegistrationFormApi.Application.Dto;

namespace RegistrationFormApi.Application.Interfaces.Repository
{
    public interface IUserRepository
    {
        Task<int> Create(UserDto userDto);
    }
}