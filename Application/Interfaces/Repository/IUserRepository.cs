using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Application.Interfaces.Repository
{
    public interface IUserRepository
    {
        Task<int> Create(User user);
    }
}