using System;

// Base class that stores basic book details
class Book
{
    public string Title;           // Title of the book
    public int PublicationYear;    // Year when book was published

    // Constructor to initialize book data
    public Book(string title, int year)
    {
        Title = title;
        PublicationYear = year;
    }

    // Method to display book details
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Book Title: {Title}");
        Console.WriteLine($"Published Year: {PublicationYear}");
    }
}

// Author class inherits Book
class Author : Book
{
    public string Name;   // Author name
    public string Bio;    // Short author description

    // Constructor initializes both book and author details
    public Author(string title, int year, string name, string bio)
        : base(title, year)
    {
        Name = name;
        Bio = bio;
    }

    // Display both book and author information
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Author Name: {Name}");
        Console.WriteLine($"Author Bio: {Bio}");
    }
}

class Program
{
    static void Main()
    {
        // Taking book details from user
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();

        Console.Write("Enter publication year: ");
        int year = int.Parse(Console.ReadLine());

        // Taking author details from user
        Console.Write("Enter author name: ");
        string name = Console.ReadLine();

        Console.Write("Enter author bio: ");
        string bio = Console.ReadLine();

        // Creating author object (which is also a book)
        Author authorBook = new Author(title, year, name, bio);

        Console.WriteLine("\nBook Details:");
        authorBook.DisplayInfo();
    }
}
