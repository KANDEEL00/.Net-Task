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

            builder.ToTable(tb => tb.HasTrigger("trg_UpdateGovernateUserCount"));
        }
    }
}
