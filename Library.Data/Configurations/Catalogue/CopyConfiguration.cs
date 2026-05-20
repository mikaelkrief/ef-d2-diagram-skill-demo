using Library.Data.Domain.Catalogue;
using Library.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configurations.Catalogue;

public class CopyConfiguration : IEntityTypeConfiguration<Copy>
{
    public void Configure(EntityTypeBuilder<Copy> builder)
    {
        builder.ToTable("Copy");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Barcode)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasIndex(x => x.Barcode)
            .IsUnique();

        builder.Property(x => x.Condition)
            .HasConversion<string>();

        builder.Property(x => x.IsAvailable)
            .HasDefaultValue(true);

        builder.HasOne(x => x.Book)
            .WithMany(x => x.Copies)
            .HasForeignKey(x => x.BookId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
