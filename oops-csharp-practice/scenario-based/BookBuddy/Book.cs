using System;

// Program starts here
class Book
{
    static void Main()
    {
        IBookService bookService = new BookService(); // Loose coupling
        MenuHandler.ShowMenu(bookService);            // Start menu
    }
}
