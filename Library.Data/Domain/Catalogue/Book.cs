using Library.Data.Domain.Loans;

namespace Library.Data.Domain.Catalogue;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string ISBN { get; set; } = null!;
    public int PublishedYear { get; set; }
    public int TotalCopies { get; set; }
    public int AvailableCopies { get; set; }
    public int CategoryId { get; set; }

    public Category Category { get; set; } = null!;
    public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
    public ICollection<Copy> Copies { get; set; } = new List<Copy>();
    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
