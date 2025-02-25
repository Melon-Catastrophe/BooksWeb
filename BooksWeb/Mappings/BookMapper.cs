namespace BooksWeb.Mappings;

using BooksWeb.Models;
using BooksWeb.Models.ViewModels;

public interface IBookMapper
{
    BookViewModel ToViewModel(Book book);
    Book ToModel(BookViewModel bookViewModel);
}

/// <summary>
/// Maps a Book to a BookViewModel or vice versa.
/// </summary>
/// <remarks>
/// A mapping library such as Automapper may be better utilized here, but for 
/// such a small application, using a manual mapper is fine.
/// </remarks>
public class BookMapper : IBookMapper
{
    /// <summary>
    /// Used to map a Book to a BookViewModel.
    /// </summary>
    /// <param name="book">The Book desired to convert to a BookViewModel.</param>
    public BookViewModel ToViewModel(Book book)
    {
        BookViewModel bookViewModel = new()
        {
            Title = book.Title,
            Author = book.Author,
            PublishedYearDisplay = book.PublishedYear.ToString()
        };

        if (DateTime.Now.Year - book.PublishedYear > 10)
        {
            bookViewModel.PublishedYearDisplay += " (Classic)";
        }

        return bookViewModel;
    }

    /// <summary>
    /// Used to map a BookViewModel to a Book.
    /// </summary>
    /// <param name="bookViewModel">The BookViewModel desired to convert to a Book.</param>
    public Book ToModel(BookViewModel bookViewModel)
    {
        bool isDisplayYearNumeric = int.TryParse(bookViewModel.PublishedYearDisplay, out int result);

        return new Book()
        {
            Title = bookViewModel.Title,
            Author = bookViewModel.Author,
            PublishedYear = isDisplayYearNumeric ? result : Int32.Parse(bookViewModel.PublishedYearDisplay.Substring(0, 4))
        };
    }
}
