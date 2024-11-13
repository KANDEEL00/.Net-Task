using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Domain.Configrations
{
    public class GovernateUserCountConfiguration : IEntityTypeConfiguration<GovernateUserCount>
    {
        public void Configure(EntityTypeBuilder<GovernateUserCount> builder)
        {
            builder.HasKey(gu => gu.GovernateID);

            builder.HasOne(gu => gu.Governate)
                   .WithOne(g => g.GovernateUserCount)
                   .HasForeignKey<Governate>(g => g.GovernateID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
