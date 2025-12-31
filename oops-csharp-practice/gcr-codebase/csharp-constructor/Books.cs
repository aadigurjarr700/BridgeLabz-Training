using System;

// Parent class
class Books
{
    public string ISBN = "";
    protected string title = "";
    private string author = "";

    public void SetAuthor(string a)
    {
        author = a;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetTitle(string t)
    {
        title = t;
    }
}

// Child class
class EBook : Books
{
    public void ShowBook()
    {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title);       // protected accessed here
        Console.WriteLine("Author: " + GetAuthor());
    }
}

class Program2
{
    static void Main()
    {
        EBook b = new EBook();

        Console.Write("Enter ISBN: ");
        b.ISBN = Console.ReadLine() ?? "";

        Console.Write("Enter Title: ");
        b.SetTitle(Console.ReadLine() ?? "");

        Console.Write("Enter Author: ");
        b.SetAuthor(Console.ReadLine() ?? "");

        b.ShowBook();
    }
}
