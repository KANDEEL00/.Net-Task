using Microsoft.EntityFrameworkCore;
using Task.Domain.Entities;

namespace Task.Application.Interfaces
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