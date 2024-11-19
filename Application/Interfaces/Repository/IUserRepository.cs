using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Application.Interfaces.Repository
{
    public interface IUserRepository
    {
        User Create(User user);
    }
}