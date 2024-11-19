using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Application.Interfaces.Repository
{
    public interface ICityRepository
    {
        Task<List<City>> GetCitiesOfGovernate(int GovernateID);
    }
}