using System;

class NumberGuessing1
{
    static Random rand=new Random();

    static int GenerateGuess(int min,int max)
    {
        return rand.Next(min,max+1);//random thr guess
    }

    static void Main()
    {
        Console.WriteLine("Think of a number between 1 and 100.");
        int min=1,max=100;
        bool guessed=false;

        while(!guessed)
        {
            int guess=GenerateGuess(min,max);
            Console.WriteLine("Computer guesses: "+guess);
            Console.WriteLine("Enter feedback (low/high/correct):");
            string feedback=Console.ReadLine().ToLower();

            if(feedback=="low") min=guess+1;
            else if(feedback=="high") max=guess-1;
            else if(feedback=="correct")
            {
                Console.WriteLine("Computer guessed correctly!");
                guessed=true;
            }
            else Console.WriteLine("Invalid input, try again.");
        }
    }
}
