using Library.Data.Domain.Administration;
using Library.Data.Domain.Catalogue;
using Library.Data.Domain.Loans;
using Library.Data.Domain.Members;
using Microsoft.EntityFrameworkCore;

namespace Library.Data;

public class LibraryDbContext : DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
    }

    #region Catalogue
    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<BookAuthor> BookAuthors { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Copy> Copies { get; set; } = null!;
    #endregion

    #region Members
    public DbSet<Member> Members { get; set; } = null!;
    public DbSet<MemberType> MemberTypes { get; set; } = null!;
    public DbSet<Subscription> Subscriptions { get; set; } = null!;
    #endregion

    #region Loans
    public DbSet<Loan> Loans { get; set; } = null!;
    public DbSet<Reservation> Reservations { get; set; } = null!;
    public DbSet<Fine> Fines { get; set; } = null!;
    #endregion

    #region Administration
    public DbSet<Staff> Staff { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;
    public DbSet<AuditLog> AuditLogs { get; set; } = null!;
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LibraryDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
