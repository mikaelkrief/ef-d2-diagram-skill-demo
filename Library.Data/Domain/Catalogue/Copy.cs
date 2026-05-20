using Library.Data.Domain.Loans;
using Library.Data.Enums;

namespace Library.Data.Domain.Catalogue;

public class Copy
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public string Barcode { get; set; } = null!;
    public BookCondition Condition { get; set; }
    public bool IsAvailable { get; set; }

    public Book Book { get; set; } = null!;
    public ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
