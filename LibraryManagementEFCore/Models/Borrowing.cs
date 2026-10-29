namespace LibraryEFCore.Models;

public class Borrowing
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;

    public int MemberId { get; set; }
    public Member Member { get; set; } = null!;

    public DateTime BorrowedDate { get; set; } = DateTime.UtcNow;
    public DateTime? ReturnedDate { get; set; }
}