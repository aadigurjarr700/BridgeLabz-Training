using System;

class Book
{
    string title;
    string author;
    double price;

    // Default constructor
    Book()
    {
        title="Unknown";
        author="Unknown";
        price=0;
    }

    // Parameterized constructor
    Book(string t,string a,double p)
    {
        title=t;
        author=a;
        price=p;
    }

    // Display book details
    void Show()
    {
        Console.WriteLine("Title: "+title);
        Console.WriteLine("Author: "+author);
        Console.WriteLine("Price: "+price);
    }

    static void Main()
    {
        // Taking input from user
        Console.Write("Enter book title: ");
        string t=Console.ReadLine();

        Console.Write("Enter author name: ");
        string a=Console.ReadLine();

        Console.Write("Enter book price: ");
        double p=Convert.ToDouble(Console.ReadLine());

        // Creating object using parameterized constructor
        Book book=new Book(t,a,p);
        book.Show();
    }
}
