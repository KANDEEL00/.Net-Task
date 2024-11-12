using Microsoft.EntityFrameworkCore;
using RegistrationFormApi.Application.Interfaces;
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
            modelBuilder.Entity<User>()
                .HasMany(u => u.Addresses)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserID)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Address>()
                .HasOne(a => a.Governate)
                .WithMany(g => g.Addresses)
                .HasForeignKey(a => a.GovernateID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Address>()
                .ToTable(tb => tb.HasTrigger("trg_UpdateGovernateUserCount"));


            modelBuilder.Entity<City>()
                .HasOne(c => c.Governate)
                .WithMany(g => g.Cities)
                .HasForeignKey(c => c.GovernateID)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<GovernateUserCount>()
                .HasKey(gu => gu.GovernateID);

            modelBuilder.Entity<GovernateUserCount>()
                .HasOne(gu => gu.Governate)
                .WithOne()
                .HasForeignKey<GovernateUserCount>(gu => gu.GovernateID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
