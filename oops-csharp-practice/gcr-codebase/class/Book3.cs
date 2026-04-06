using System;

class Book
{
    // variables to store book information
    string title;
    string author;
    double price;

    // method to take book details
    public void TakeBookDetails()
    {
        Console.Write("Enter Book Title: ");
        title = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        author = Console.ReadLine();

        Console.Write("Enter Book Price: ");
        price = Convert.ToDouble(Console.ReadLine());
    }

    // method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine("\nBook Details:");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}

class Program
{
    static void Main()
    {
        // creating book object
        Book book = new Book();

        // taking input from user
        book.TakeBookDetails();

        // displaying book information
        book.DisplayBookDetails();
    }
}
