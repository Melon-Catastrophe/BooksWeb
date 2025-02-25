namespace BooksWeb.Controllers;

using BooksWeb.Mappings;
using BooksWeb.Models.ViewModels;
using BooksWeb.Repositories;
using Microsoft.AspNetCore.Mvc;
using Models;

public class BookController : Controller
{
    private readonly MockBookRepository booksRepository = new();
    private readonly BookMapper mapper = new();
    
    /// <summary>
    /// The landing page of the web app. Displays a table of all the books in the database.
    /// </summary>
    public IActionResult Index()
    {
        List<Book> books = booksRepository.GetAllBooks();
        List<BookViewModel> viewBooks = new();

        foreach (Book book in books)
        {
            viewBooks.Add(mapper.ToViewModel(book));
        }

        return View(viewBooks);
    }

    /// <summary>
    /// Shows details of a Book. Used to demonstrate dynamic page navigation.
    /// </summary>
    /// <param name="title">The title of the book.</param>
    public IActionResult Details(string? title)
    {
        if (title == null)
        {
            return RedirectToAction("Index");
        }

        List<Book> books = booksRepository.GetAllBooks();
        BookViewModel? foundBook = FindBookFromTitle(books, title);

        if (foundBook != null)
        {
            return View(foundBook);
        }
        else
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Searches the list of Books provided for the given title. 
    /// Returns the BookViewModel if its title is found, or null otherwise.
    /// </summary>
    /// <remarks>
    /// Ideally, this function would find the book based on its ID. However,
    /// the Index.cshtml file receives the books via the BookViewModel class,
    /// which does not contain the book's ID. If given more time, a better solution 
    /// would be found.
    /// </remarks>
    /// <param name="books">The list of all books.</param>
    /// <param name="title">The title of the book.</param>
    private BookViewModel? FindBookFromTitle(List<Book> books, string title)
    {
        foreach (Book book in books)
        {
            if (book.Title == title)
            {
                return mapper.ToViewModel(book);
            }
        }

        return null;
    }
}
