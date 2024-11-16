using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Domain.Configrations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(u => u.Addresses)
                   .WithOne(a => a.User)
                   .HasForeignKey(a => a.UserID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(u => u.FirstName)
                   .IsRequired()
                   .HasMaxLength(20)
                   .HasColumnType("nvarchar");

            builder.Property(u => u.MiddleName)
                   .HasMaxLength(40)
                   .HasColumnType("nvarchar");

            builder.Property(u => u.LastName)
                   .IsRequired()
                   .HasMaxLength(20)
                   .HasColumnType("nvarchar");

            builder.Property(u => u.BirthDate)
                   .IsRequired();

            builder.Property(u => u.MobileNumber)
                   .IsRequired()
                   .HasMaxLength(15)
                   .HasColumnType("varchar");

            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(255)
                   .HasColumnType("varchar");
        }
    }
}
