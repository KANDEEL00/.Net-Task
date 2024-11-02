using Microsoft.EntityFrameworkCore;
using Task.Data.Entities;

namespace Task.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Governate> Governates { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<GovernateUserCount> GovernateUserCounts { get; set; }

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
