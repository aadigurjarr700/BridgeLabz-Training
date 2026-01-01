using System;

class Book
{
    // Same library name for all books
    public static string LibraryName = "City Central Library";

    // Book ISBN should never change
    public readonly string ISBN;

    // Book details
    public string Title;
    public string Author;

    // Constructor to create a book
    public Book(string ISBN, string Title, string Author)
    {
        // 'this' helps assign values correctly
        this.ISBN = ISBN;
        this.Title = Title;
        this.Author = Author;
    }

    // Displays library name
    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library Name: " + LibraryName);
    }

    // Shows book details using 'is' operator for safety
    public static void ShowBookDetails(object obj)
    {
        if (obj is Book book)
        {
            Console.WriteLine("\n--- Book Details ---");
            Console.WriteLine("Title: " + book.Title);
            Console.WriteLine("Author: " + book.Author);
            Console.WriteLine("ISBN: " + book.ISBN);
        }
        else
        {
            Console.WriteLine("Given object is not a Book.");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        string author = Console.ReadLine();

        Console.Write("Enter ISBN Number: ");
        string isbn = Console.ReadLine();

        // Creating book object
        Book myBook = new Book(isbn, title, author);

        // Display common library name
        Book.DisplayLibraryName();

        // Display book information
        Book.ShowBookDetails(myBook);
    }
}
