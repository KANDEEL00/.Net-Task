using Task.Application.Dto;

namespace Task.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<int> RegisterUser(UserDto userDto);
    }
}