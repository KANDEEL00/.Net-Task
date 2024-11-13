using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Domain.Configrations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasOne(c => c.Governate)
                   .WithMany(g => g.Cities)
                   .HasForeignKey(c => c.GovernateID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
