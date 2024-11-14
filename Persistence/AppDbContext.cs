using Microsoft.EntityFrameworkCore;
using RegistrationFormApi.Application.Interfaces;
using RegistrationFormApi.Domain.Configrations;
using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Persistence
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Governate> Governates { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<GovernateUserCount> GovernateUserCounts { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var constr = "Server = .\\SQLEXPRESS ; Database = Registration ;Integrated Security = True ; TrustServerCertificate = True;";
            optionsBuilder.UseSqlServer(constr);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
            AppDbContextSeed.Seed(modelBuilder);
        }
    }
}
