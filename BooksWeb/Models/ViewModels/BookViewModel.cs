namespace BooksWeb.Models.ViewModels;

/// <summary>
/// The View Model for Books.
/// </summary>
/// <remarks>
/// The <see cref="BooksWeb.Mappings.BookMapper">BookMapper</see> maps between this class and the Book class.
/// </remarks>
public class BookViewModel
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string PublishedYearDisplay { get; set; }
}
