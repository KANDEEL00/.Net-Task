namespace RegistrationFormApi.Application.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        ICityRepository CityRepository { get; }
        IGovernateRepository GovernateRepository { get; }
        IUserRepository UserRepository { get; }

        void Save();
    }
}