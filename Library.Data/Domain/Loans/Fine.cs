namespace Library.Data.Domain.Loans;

public class Fine
{
    public int Id { get; set; }
    public int LoanId { get; set; }
    public decimal Amount { get; set; }
    public DateTime IssuedDate { get; set; }
    public DateTime? PaidDate { get; set; }
    public bool IsPaid { get; set; }

    public Loan Loan { get; set; } = null!;
}
