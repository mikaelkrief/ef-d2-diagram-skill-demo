using Library.Data.Domain.Catalogue;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configurations.Catalogue;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Book");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.ISBN)
            .IsRequired()
            .HasMaxLength(13);

        builder.HasIndex(x => x.ISBN)
            .IsUnique();

        builder.Property(x => x.TotalCopies)
            .HasDefaultValue(0);

        builder.Property(x => x.AvailableCopies)
            .HasDefaultValue(0);

        builder.HasOne(x => x.Category)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
