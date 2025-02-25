# README

This is a simple ASP.NET web application. It does the following:

- Implements a mock database providing a list of books.
- Utilizes a controller that retrieves book data, applies a transformation, and passes the BookViewModel to the view (Index.cshtml).
- Uses a manual mapper to transform the Book object to a BookViewModel object.
- Implements a View Model (BookViewModel.cs) to structure the data.
- Creates a View (Index.cshtml) that displays the book list in an HTML table.
- Creates a View (Details.cshtml) for displaying additional book details.

## Details

### Book Model

The Book Model represents a Book entity on the mocked database. It contains the following properties:

```c#
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublishedYear { get; set; }
}
```

### Book View Model

The Book Model can be transformed into the Book View Model for purposes of displaying onto the web app. It contains the following properties:

```c#
public class BookViewModel
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string PublishedYearDisplay { get; set; }
}
```

Note that 'Id' is not a property of BookViewModel.

### Book Mapper

The Book Mapper maps a Book object to a BookViewModel object and vice versa. The implementation of this mapper is manual. For larger projects, it is recommended to use a mapping library such as *AutoMapper*. For small projects like this one, however, it is fine to simply use a manual implementation.

### Mocked Book Database

The `MockBookRepository.cs` file contains a function `GetAllBooks()` that returns a list of hardcoded Book objects.

```c#
public class MockBookRepository
{
    private readonly Book book1 = new() { Id = 1, Title = "The Way of Kings", Author = "Brandon Sanderson", PublishedYear = 2010 };
    private readonly Book book2 = new() { Id = 2, Title = "Wind and Truth", Author = "Brandon Sanderson" , PublishedYear = 2024 };
    private readonly Book book3 = new() { Id = 3, Title = "Hamlet", Author = "William Shakespeare", PublishedYear = 1623 };
    private readonly Book book4 = new() { Id = 4, Title = "Macbeth", Author = "William Shakespeare", PublishedYear = 1623 };
    private readonly Book book5 = new() { Id = 5, Title = "The Girl on the Train", Author = "Paula Hawkins", PublishedYear = 2015 };
    private readonly Book book6 = new() { Id = 6, Title = "All the Light We Cannot See", Author = "Anthony Doerr", PublishedYear = 2014 };

    public List<Book> GetAllBooks()
    {
        return new List<Book>() { book1, book2, book3, book4, book5, book6 };
    }
}
```

### Additional Book Details

A details View is shown when clicking on a book's title. For now, the only details shown are the Title, Author, and Publication Year. This content is dynamically shown based on a unique ID. 

To get back to the Home screen from the Additional Details page, click on the "Back to Home" button.
