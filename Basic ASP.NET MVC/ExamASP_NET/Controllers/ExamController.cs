using ExamASP_NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamASP_NET.Controllers;

public class ExamController : Controller
{
    public IActionResult Index()
    {
        #region Liste
        List<Author> authorList = new List<Author>();
        Author author1 = new Author() { NameSurname = "J.K. Rowling", Age = 57, Country = "England" };
        authorList.Add(author1);
        Author author2 = new Author() { NameSurname = "George R.R. Martin", Age = 74, Country = "United States" };
        authorList.Add(author2);
        Author author3 = new Author() { NameSurname = "Andrzej Sapkowski", Age = 74, Country = "Poland" };
        authorList.Add(author3);

        List<Book> booksList = new List<Book>();
        Book book1 = new Book() { Title = "The Last Wish", Author = author3, Genre = "Fantasy", YearOfRelease = 1993 };
        booksList.Add(book1);
        Book book2 = new Book() { Title = "Blood of Elves", Author = author3, Genre = "Fantasy", YearOfRelease = 1994 };
        booksList.Add(book2);
        Book book3 = new Book() { Title = "Harry Potter and the Chamber of Secrets", Author = author1, Genre = "Fiction", YearOfRelease = 1998 };
        booksList.Add(book3);
        Book book4 = new Book() { Title = "A Game of Thrones", Author = author2, Genre = "Fantasy", YearOfRelease = 1996 };
        booksList.Add(book4);
        Book book5 = new Book() { Title = "A Clash of Kings", Author = author2, Genre = "Fantasy", YearOfRelease = 1998 };
        booksList.Add(book5);
        #endregion

        ViewData["books"] = booksList;


        return View("Exam");
    }
}
