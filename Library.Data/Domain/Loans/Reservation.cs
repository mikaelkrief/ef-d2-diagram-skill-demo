using Library.Data.Domain.Catalogue;
using Library.Data.Domain.Members;
using Library.Data.Enums;

namespace Library.Data.Domain.Loans;

public class Reservation
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public int MemberId { get; set; }
    public DateTime ReservationDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public ReservationStatus Status { get; set; }

    public Book Book { get; set; } = null!;
    public Member Member { get; set; } = null!;
}
