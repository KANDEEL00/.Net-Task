using Task.Data.DTOs;

namespace Task.Service
{
    public interface IUserService
    {
        Task<int> RegisterUser(UserDTO userDto);
    }
}