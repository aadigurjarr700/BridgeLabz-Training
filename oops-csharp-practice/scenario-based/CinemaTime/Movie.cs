using System;

class Movie
{
    // Private fields (Encapsulation)
    private string title;
    private string showTime;

    // Public properties
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string ShowTime
    {
        get { return showTime; }
        set { showTime = value; }
    }

    // Method to return formatted movie details
    public string GetMovieDetails()
    {
        return string.Format("Movie: {0} | Show Time: {1}", title, showTime);
    }
}
