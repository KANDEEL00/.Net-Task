using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Application.Interfaces.Repository
{
    public interface IGovernateRepository
    {
        List<Governate> GetAll();
    }
}