using Microsoft.EntityFrameworkCore;
using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Application.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<Address> Addresses { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Governate> Governates { get; set; }
        DbSet<GovernateUserCount> GovernateUserCounts { get; set; }
        DbSet<User> Users { get; set; }

    }
}