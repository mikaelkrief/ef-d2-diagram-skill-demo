namespace Library.Data.Domain.Administration;

public class AuditLog
{
    public int Id { get; set; }
    public int StaffId { get; set; }
    public string Action { get; set; } = null!;
    public string EntityName { get; set; } = null!;
    public int EntityId { get; set; }
    public DateTime OccurredAt { get; set; }
    public string? Details { get; set; }

    public Staff Staff { get; set; } = null!;
}
