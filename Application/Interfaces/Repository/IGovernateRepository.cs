using RegistrationFormApi.Application.Dto;

namespace RegistrationFormApi.Application.Interfaces.Repository
{
    public interface IGovernateRepository
    {
        Task<List<GovernateDto>> GetAll();
    }
}