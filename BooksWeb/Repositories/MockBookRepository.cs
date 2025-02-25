namespace BooksWeb.Repositories;

using Models;

/// <summary>
/// A mock database for storing Books.
/// </summary>
public class MockBookRepository
{
    private readonly Book book1 = new() { Id = 1, Title = "The Way of Kings", Author = "Brandon Sanderson", PublishedYear = 2010 };
    private readonly Book book2 = new() { Id = 2, Title = "Wind and Truth", Author = "Brandon Sanderson" , PublishedYear = 2024 };
    private readonly Book book3 = new() { Id = 3, Title = "Hamlet", Author = "William Shakespeare", PublishedYear = 1623 };
    private readonly Book book4 = new() { Id = 4, Title = "Macbeth", Author = "William Shakespeare", PublishedYear = 1623 };
    private readonly Book book5 = new() { Id = 5, Title = "The Girl on the Train", Author = "Paula Hawkins", PublishedYear = 2015 };
    private readonly Book book6 = new() { Id = 6, Title = "All the Light We Cannot See", Author = "Anthony Doerr", PublishedYear = 2014 };

    /// <summary>
    /// Returns all the Books in the mock database.
    /// </summary>
    /// <returns>A list of all <see cref="Book">Books</see> in the mock database.</returns>
    public List<Book> GetAllBooks()
    {
        return new List<Book>() { book1, book2, book3, book4, book5, book6 };
    }
}
