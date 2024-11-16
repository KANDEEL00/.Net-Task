using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Domain.Configrations
{
    public class GovernateConfiguration : IEntityTypeConfiguration<Governate>
    {
        public void Configure(EntityTypeBuilder<Governate> builder)
        {
            builder.HasOne(g => g.GovernateUserCount)
                   .WithOne(gu => gu.Governate)
                   .HasForeignKey<GovernateUserCount>(gu => gu.GovernateID);  // Foreign key in GovernateUserCount

            builder.Property(g => g.GovernateName)
                   .IsRequired()
                   .HasMaxLength(20)
                   .HasColumnType("varchar");
        }
    }
}
