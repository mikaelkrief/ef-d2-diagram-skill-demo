namespace Library.Data.Domain.Members;

public class Subscription
{
    public int Id { get; set; }
    public int MemberId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsPaid { get; set; }
    public DateTime? PaidAt { get; set; }

    public Member Member { get; set; } = null!;
}
