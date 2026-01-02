using System;
using System.Collections.Generic;

class Book
{
    public string Title;
    public string Author;

    // Book is created independently
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

class Library
{
    public string LibraryName;
    public List<Book> Books = new List<Book>();

    public Library(string name)
    {
        LibraryName = name;
    }

    // Add already created book to library
    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void ShowBooks()
    {
        Console.WriteLine("\nBooks in " + LibraryName + ":");
        foreach (Book b in Books)
        {
            Console.WriteLine(b.Title + " by " + b.Author);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter library name: ");
        string libName = Console.ReadLine();
        Library library = new Library(libName);

        Console.Write("How many books you want to add? ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 1; i <= count; i++)
        {
            Console.Write("\nEnter book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter author name: ");
            string author = Console.ReadLine();

            Book book = new Book(title, author);
            library.AddBook(book);
        }

        library.ShowBooks();
    }
}
