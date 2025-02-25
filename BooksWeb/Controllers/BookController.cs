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
}
