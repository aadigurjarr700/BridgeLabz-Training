using System;

class LuckyDraw
{
    // This method handles the full lucky draw game
    public void StartGame()
    {
        while(true)
        {
            Console.Write("Enter a lucky number (enter -1 to exit): ");

            // Read input safely
            bool isNumber = int.TryParse(Console.ReadLine(), out int number);

            // If input is not a number
            if(!isNumber)
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            // Stop the game
            if(number == -1)
            {
                Console.WriteLine("Lucky Draw ended. Thank you!");
                break;
            }

            // Check winning condition
            if(number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Congratulations! You won a gift 🎁");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        // Create object of LuckyDraw class
        LuckyDraw game = new LuckyDraw();

        // Start the lucky draw
        game.StartGame();
    }
}
