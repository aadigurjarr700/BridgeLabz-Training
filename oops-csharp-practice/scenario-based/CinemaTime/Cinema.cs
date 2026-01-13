using System;

class Cinema
{
    static void Main()
    {
        IMovieService movieService = new MovieServiceImpl();
        int choice;

        do
        {
            Console.WriteLine("\n===== CinemaTime – Movie Schedule Manager =====");
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Search Movie");
            Console.WriteLine("3. Display All Movies");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Movie Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter Show Time: ");
                    string time = Console.ReadLine();

                    movieService.AddMovie(title, time);
                    break;

                case 2:
                    Console.Write("Enter keyword to search: ");
                    string keyword = Console.ReadLine();

                    movieService.SearchMovie(keyword);
                    break;

                case 3:
                    movieService.DisplayAllMovies();
                    break;

                case 4:
                    Console.WriteLine("Thank you for using CinemaTime!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        } while (choice != 4);
    }
}
