namespace Library.Data.Domain.Administration;

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
