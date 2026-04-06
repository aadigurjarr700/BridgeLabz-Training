using System;

// Interface for reservable behavior
interface IReservable
{
    void ReserveItem(string borrowerName);
    bool CheckAvailability();
}

// Abstract base class
abstract class LibraryItem
{
    private int itemId;
    private string title;
    private string author;

    // borrower data is sensitive, so kept private (encapsulation)
    private string borrowedBy;
    private bool isAvailable = true;

    protected LibraryItem(int id, string title, string author)
    {
        itemId = id;
        this.title = title;
        this.author = author;
    }

    // force child classes to define loan rules
    public abstract int GetLoanDuration();

    // common method for all items
    public void GetItemDetails()
    {
        Console.WriteLine($"ID     : {itemId}");
        Console.WriteLine($"Title  : {title}");
        Console.WriteLine($"Author : {author}");
    }

    // helper methods only for subclasses
    protected void Reserve(string name)
    {
        borrowedBy = name;
        isAvailable = false;
    }

    protected bool IsAvailable()
    {
        return isAvailable;
    }
}

// Book class
class Book : LibraryItem, IReservable
{
    public Book(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 14; // books allowed for 14 days
    }

    public void ReserveItem(string borrowerName)
    {
        if (IsAvailable())
        {
            Reserve(borrowerName);
            Console.WriteLine("Book reserved successfully.");
        }
        else
        {
            Console.WriteLine("Book already issued.");
        }
    }

    public bool CheckAvailability()
    {
        return IsAvailable();
    }
}

// Magazine class
class Magazine : LibraryItem, IReservable
{
    public Magazine(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 7; // magazines for shorter duration
    }

    public void ReserveItem(string borrowerName)
    {
        if (IsAvailable())
        {
            Reserve(borrowerName);
            Console.WriteLine("Magazine reserved successfully.");
        }
        else
        {
            Console.WriteLine("Magazine not available.");
        }
    }

    public bool CheckAvailability()
    {
        return IsAvailable();
    }
}

// DVD class
class DVD : LibraryItem, IReservable
{
    public DVD(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 3; // DVDs for very short duration
    }

    public void ReserveItem(string borrowerName)
    {
        if (IsAvailable())
        {
            Reserve(borrowerName);
            Console.WriteLine("DVD reserved successfully.");
        }
        else
        {
            Console.WriteLine("DVD already issued.");
        }
    }

    public bool CheckAvailability()
    {
        return IsAvailable();
    }
}

// Main class
class LibraryApp
{
    static void Main()
    {
        Console.WriteLine("Choose Item Type:");
        Console.WriteLine("1. Book");
        Console.WriteLine("2. Magazine");
        Console.WriteLine("3. DVD");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter Item ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Author: ");
        string author = Console.ReadLine();

        LibraryItem item;

        if (choice == 1)
            item = new Book(id, title, author);
        else if (choice == 2)
            item = new Magazine(id, title, author);
        else
            item = new DVD(id, title, author);

        // polymorphism in action
        item.GetItemDetails();
        Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days");

        Console.Write("Enter borrower name: ");
        string borrower = Console.ReadLine();

        ((IReservable)item).ReserveItem(borrower);
    }
}
