using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Domain.Configrations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasOne(a => a.Governate)
                   .WithMany(g => g.Addresses)
                   .HasForeignKey(a => a.GovernateID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.City)
                   .WithMany(c => c.Addresses)
                   .HasForeignKey(a => a.CityID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Property(a => a.Street)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(a => a.BuildingNumber)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(a => a.FlatNumber)
                   .IsRequired();

            builder.ToTable(tb => tb.HasTrigger("trg_UpdateGovernateUserCount"));
        }
    }
}
