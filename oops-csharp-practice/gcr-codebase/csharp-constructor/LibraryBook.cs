using System;

class LibraryBook
{
    string title;
    string author;
    bool available;

    // Constructor
    LibraryBook(string t,string a)
    {
        title=t;
        author=a;
        available=true;
    }

    // Borrow book
    void BorrowBook()
    {
        if(available)
        {
            available=false;
            Console.WriteLine("Book borrowed successfully.");
        }
        else
        {
            Console.WriteLine("Book already borrowed.");
        }
    }

    static void Main()
    {
        Console.Write("Enter book title: ");
        string t=Console.ReadLine();

        Console.Write("Enter author name: ");
        string a=Console.ReadLine();

        LibraryBook book=new LibraryBook(t,a);
        book.BorrowBook();
        book.BorrowBook();
    }
}
