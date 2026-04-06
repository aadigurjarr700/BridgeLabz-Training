using System;
using System.Collections.Generic;

class MovieServiceImpl : IMovieService
{
    // List to store movie objects
    private List<Movie> movies = new List<Movie>();

    // Add a movie
    public void AddMovie(string title, string time)
    {
        Movie movie = new Movie();
        movie.Title = title;
        movie.ShowTime = time;

        movies.Add(movie);
        Console.WriteLine("Movie added successfully.");
    }

    // Search movie by keyword using Contains()
    public void SearchMovie(string keyword)
    {
        bool found = false;

        foreach (Movie movie in movies)
        {
            if (movie.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(movie.GetMovieDetails());
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No movie found with given keyword.");
        }
    }

    // Display all movies
    public void DisplayAllMovies()
    {
        if (movies.Count == 0)
        {
            Console.WriteLine("No movies available.");
            return;
        }

        Console.WriteLine("\n--- Movie Schedule ---");
        foreach (Movie movie in movies)
        {
            Console.WriteLine(movie.GetMovieDetails());
        }
    }
}
