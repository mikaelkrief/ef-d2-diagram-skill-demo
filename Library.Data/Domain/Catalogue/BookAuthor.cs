namespace Library.Data.Domain.Catalogue;

public class BookAuthor
{
    public int BookId { get; set; }
    public int AuthorId { get; set; }
    public string? Role { get; set; }

    public Book Book { get; set; } = null!;
    public Author Author { get; set; } = null!;
}
