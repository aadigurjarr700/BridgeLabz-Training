using System;

// Node class for Doubly Linked List
class BookNode
{
    // Book details
    public int BookId;
    public string Title;
    public string Author;
    public string Genre;
    public bool IsAvailable;

    // Pointers
    public BookNode Next;
    public BookNode Prev;

    // Constructor
    public BookNode(int bookId, string title, string author, string genre, bool isAvailable)
    {
        BookId = bookId;
        Title = title;
        Author = author;
        Genre = genre;
        IsAvailable = isAvailable;
        Next = null;
        Prev = null;
    }
}

// Doubly Linked List class
class LibraryDoublyLinkedList
{
    private BookNode head;
    private BookNode tail;

    // Add book at beginning
    public void AddAtBeginning(int id, string title, string author, string genre, bool available)
    {
        BookNode newNode = new BookNode(id, title, author, genre, available);

        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
    }

    // Add book at end
    public void AddAtEnd(int id, string title, string author, string genre, bool available)
    {
        BookNode newNode = new BookNode(id, title, author, genre, available);

        if (tail == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
    }

    // Add book at specific position
    public void AddAtPosition(int position, int id, string title, string author, string genre, bool available)
    {
        if (position <= 1)
        {
            AddAtBeginning(id, title, author, genre, available);
            return;
        }

        BookNode temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp == null || temp.Next == null)
        {
            AddAtEnd(id, title, author, genre, available);
            return;
        }

        BookNode newNode = new BookNode(id, title, author, genre, available);
        newNode.Next = temp.Next;
        newNode.Prev = temp;
        temp.Next.Prev = newNode;
        temp.Next = newNode;
    }

    // Remove book by Book ID
    public void RemoveByBookId(int bookId)
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty");
            return;
        }

        BookNode temp = head;

        while (temp != null && temp.BookId != bookId)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Book not found");
            return;
        }

        if (temp == head)
        {
            head = head.Next;
            if (head != null) head.Prev = null;
        }
        else if (temp == tail)
        {
            tail = tail.Prev;
            tail.Next = null;
        }
        else
        {
            temp.Prev.Next = temp.Next;
            temp.Next.Prev = temp.Prev;
        }

        Console.WriteLine("Book removed successfully");
    }

    // Search book by title
    public void SearchByTitle(string title)
    {
        BookNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                DisplayBook(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("Book not found");
    }

    // Search book by author
    public void SearchByAuthor(string author)
    {
        BookNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                DisplayBook(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No books found for this author");
    }

    // Update availability status
    public void UpdateAvailability(int bookId, bool status)
    {
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.BookId == bookId)
            {
                temp.IsAvailable = status;
                Console.WriteLine("Book availability updated");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Book not found");
    }

    // Display books in forward order
    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("No books available");
            return;
        }

        BookNode temp = head;
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.Next;
        }
    }

    // Display books in reverse order
    public void DisplayReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("No books available");
            return;
        }

        BookNode temp = tail;
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.Prev;
        }
    }

    // Count total books
    public void CountBooks()
    {
        int count = 0;
        BookNode temp = head;

        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }

        Console.WriteLine("Total number of books: " + count);
    }

    // Helper method to display a book
    private void DisplayBook(BookNode book)
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("Book ID     : " + book.BookId);
        Console.WriteLine("Title       : " + book.Title);
        Console.WriteLine("Author      : " + book.Author);
        Console.WriteLine("Genre       : " + book.Genre);
        Console.WriteLine("Available   : " + (book.IsAvailable ? "Yes" : "No"));
    }
}

// Main class
class Program
{
    static void Main()
    {
        LibraryDoublyLinkedList library = new LibraryDoublyLinkedList();

        library.AddAtEnd(1, "Clean Code", "Robert Martin", "Programming", true);
        library.AddAtBeginning(2, "The Alchemist", "Paulo Coelho", "Fiction", true);
        library.AddAtPosition(2, 3, "1984", "George Orwell", "Dystopian", false);

        Console.WriteLine("All Books (Forward):");
        library.DisplayForward();

        Console.WriteLine("\nAll Books (Reverse):");
        library.DisplayReverse();

        Console.WriteLine("\nSearch by Author:");
        library.SearchByAuthor("George Orwell");

        Console.WriteLine("\nUpdate Availability:");
        library.UpdateAvailability(3, true);

        Console.WriteLine("\nRemove Book ID 1:");
        library.RemoveByBookId(1);

        Console.WriteLine("\nFinal Library:");
        library.DisplayForward();

        Console.WriteLine("\nBook Count:");
        library.CountBooks();
    }
}
