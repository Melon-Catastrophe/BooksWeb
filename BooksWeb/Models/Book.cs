namespace BooksWeb.Models;

/// <summary>
/// The Model for Books.
/// </summary>
/// <remarks>
/// The <see cref="BooksWeb.Mappings.BookMapper">BookMapper</see> maps between this class and the BookViewModel class.
/// </remarks>
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublishedYear { get; set; }
}
