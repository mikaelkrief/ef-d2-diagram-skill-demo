namespace Library.Data.Domain.Members;

public class MemberType
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int MaxLoans { get; set; }
    public int LoanDurationDays { get; set; }

    public ICollection<Member> Members { get; set; } = new List<Member>();
}
