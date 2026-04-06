using System;

class MovieNode
{
    // Movie details
    public string Title;
    public string Director;
    public int Year;
    public double Rating;

    // Pointers for doubly linked list
    public MovieNode Next;
    public MovieNode Prev;

    // Constructor
    public MovieNode(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Next = null;
        Prev = null;
    }
}

// Doubly Linked List class
class MovieDoublyLinkedList
{
    private MovieNode head;
    private MovieNode tail;

    // Add movie at beginning
    public void AddAtBeginning(string title, string director, int year, double rating)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);

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

    // Add movie at end
    public void AddAtEnd(string title, string director, int year, double rating)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);

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

    // Add movie at specific position
    public void AddAtPosition(int position, string title, string director, int year, double rating)
    {
        if (position <= 1)
        {
            AddAtBeginning(title, director, year, rating);
            return;
        }

        MovieNode temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp == null || temp.Next == null)
        {
            AddAtEnd(title, director, year, rating);
            return;
        }

        MovieNode newNode = new MovieNode(title, director, year, rating);
        newNode.Next = temp.Next;
        newNode.Prev = temp;
        temp.Next.Prev = newNode;
        temp.Next = newNode;
    }

    // Remove movie by title
    public void RemoveByTitle(string title)
    {
        if (head == null)
        {
            Console.WriteLine("No movie records available");
            return;
        }

        MovieNode temp = head;

        while (temp != null && temp.Title != title)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Movie not found");
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

        Console.WriteLine("Movie removed successfully");
    }

    // Search movie by director
    public void SearchByDirector(string director)
    {
        MovieNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
            {
                DisplayMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No movies found for this director");
    }

    // Search movie by rating
    public void SearchByRating(double rating)
    {
        MovieNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Rating >= rating)
            {
                DisplayMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No movies found with this rating");
    }

    // Update movie rating by title
    public void UpdateRating(string title, double newRating)
    {
        MovieNode temp = head;

        while (temp != null)
        {
            if (temp.Title == title)
            {
                temp.Rating = newRating;
                Console.WriteLine("Movie rating updated successfully");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Movie not found");
    }

    // Display movies in forward order
    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("No movie records available");
            return;
        }

        MovieNode temp = head;
        while (temp != null)
        {
            DisplayMovie(temp);
            temp = temp.Next;
        }
    }

    // Display movies in reverse order
    public void DisplayReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("No movie records available");
            return;
        }

        MovieNode temp = tail;
        while (temp != null)
        {
            DisplayMovie(temp);
            temp = temp.Prev;
        }
    }

    // Helper method to display single movie
    private void DisplayMovie(MovieNode movie)
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("Title    : " + movie.Title);
        Console.WriteLine("Director : " + movie.Director);
        Console.WriteLine("Year     : " + movie.Year);
        Console.WriteLine("Rating   : " + movie.Rating);
    }
}

// Main class
class Program
{
    static void Main()
    {
        MovieDoublyLinkedList movies = new MovieDoublyLinkedList();

        movies.AddAtEnd("Inception", "Christopher Nolan", 2010, 8.8);
        movies.AddAtBeginning("Interstellar", "Christopher Nolan", 2014, 8.6);
        movies.AddAtPosition(2, "Avatar", "James Cameron", 2009, 7.9);

        Console.WriteLine("All Movies (Forward):");
        movies.DisplayForward();

        Console.WriteLine("\nAll Movies (Reverse):");
        movies.DisplayReverse();

        Console.WriteLine("\nSearch by Director:");
        movies.SearchByDirector("Christopher Nolan");

        Console.WriteLine("\nUpdate Rating:");
        movies.UpdateRating("Avatar", 8.1);

        Console.WriteLine("\nRemove Movie:");
        movies.RemoveByTitle("Inception");

        Console.WriteLine("\nFinal Movie List:");
        movies.DisplayForward();
    }
}
