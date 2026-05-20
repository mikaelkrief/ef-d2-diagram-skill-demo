namespace Library.Data.Domain.Administration;

public class Staff
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public int RoleId { get; set; }
    public DateTime HiredAt { get; set; }
    public bool IsActive { get; set; }

    public Role Role { get; set; } = null!;
    public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
}
