using Library.Data.Domain.Loans;

namespace Library.Data.Domain.Members;

public class Member
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? Phone { get; set; }
    public string MemberNumber { get; set; } = null!;
    public int MemberTypeId { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }

    public MemberType MemberType { get; set; } = null!;
    public ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
    public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
