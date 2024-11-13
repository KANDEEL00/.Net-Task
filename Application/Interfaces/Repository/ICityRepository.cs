using RegistrationFormApi.Application.Dto;

namespace RegistrationFormApi.Application.Interfaces.Repository
{
    public interface ICityRepository
    {
        Task<List<CityDto>> GetCitiesOfGovernate(int GovernateID);
    }
}