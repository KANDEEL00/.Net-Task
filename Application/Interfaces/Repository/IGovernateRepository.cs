using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Application.Interfaces.Repository
{
    public interface IGovernateRepository
    {
        Task<List<Governate>> GetAll();
    }
}