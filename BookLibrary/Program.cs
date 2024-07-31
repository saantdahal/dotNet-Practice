using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int Pages { get; set; }
}

public class Library
{
    private List<Book> books = new List<Book>();

    // Method to add a new book to the library
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book '{book.Title}' by {book.Author} added to the library.");
    }

    // Method to find a book by its title
    public Book FindBookByTitle(string title)
    {
        return books.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }

    // Method to list all books in the library
    public void ListAllBooks()
    {
        Console.WriteLine("Listing all books in the library:");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Pages: {book.Pages}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create a few Book objects with valid and invalid data
        Book book1 = new Book { Title = "1984", Author = "George Orwell", ISBN = "9780451524935", Pages = 328 };
        Book book2 = new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", ISBN = "9780061120084", Pages = 281 };
        Book book3 = new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", ISBN = "9780743273565", Pages = 180 };

        // Create a Library object
        Library library = new Library();

        // Add books to the library
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        // Search for a book by its title
        string searchTitle = "1984";
        Book foundBook = library.FindBookByTitle(searchTitle);
        if (foundBook != null)
        {
            Console.WriteLine($"Found book: Title: {foundBook.Title}, Author: {foundBook.Author}, ISBN: {foundBook.ISBN}, Pages: {foundBook.Pages}");
        }
        else
        {
            Console.WriteLine($"Book with title '{searchTitle}' not found.");
        }

        // List all books in the library
        library.ListAllBooks();
    }
}
