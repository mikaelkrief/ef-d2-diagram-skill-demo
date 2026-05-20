using Library.Data.Domain.Loans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configurations.Loans;

public class FineConfiguration : IEntityTypeConfiguration<Fine>
{
    public void Configure(EntityTypeBuilder<Fine> builder)
    {
        builder.ToTable("Fine");

        builder.HasKey(x => x.Id);

        builder.HasIndex(x => x.LoanId)
            .IsUnique();

        builder.Property(x => x.Amount)
            .HasColumnType("decimal(10,2)");

        builder.Property(x => x.IsPaid)
            .HasDefaultValue(false);

        builder.HasOne(x => x.Loan)
            .WithOne(x => x.Fine)
            .HasForeignKey<Fine>(x => x.LoanId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
