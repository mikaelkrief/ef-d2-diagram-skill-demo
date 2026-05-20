using Library.Data.Domain.Members;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configurations.Members;

public class MemberTypeConfiguration : IEntityTypeConfiguration<MemberType>
{
    public void Configure(EntityTypeBuilder<MemberType> builder)
    {
        builder.ToTable("MemberType");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasIndex(x => x.Name)
            .IsUnique();

        builder.Property(x => x.MaxLoans)
            .HasDefaultValue(3);

        builder.Property(x => x.LoanDurationDays)
            .HasDefaultValue(14);
    }
}
