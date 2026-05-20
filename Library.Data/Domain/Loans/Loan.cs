using Library.Data.Domain.Catalogue;
using Library.Data.Domain.Members;
using Library.Data.Enums;

namespace Library.Data.Domain.Loans;

public class Loan
{
    public int Id { get; set; }
    public int CopyId { get; set; }
    public int MemberId { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public LoanStatus Status { get; set; }

    public Copy Copy { get; set; } = null!;
    public Member Member { get; set; } = null!;
    public Fine? Fine { get; set; }
}
