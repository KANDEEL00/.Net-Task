using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Application.Interfaces.Repository
{
    public interface ICityRepository
    {
        List<City> GetCitiesOfGovernate(int GovernateID);
    }
}