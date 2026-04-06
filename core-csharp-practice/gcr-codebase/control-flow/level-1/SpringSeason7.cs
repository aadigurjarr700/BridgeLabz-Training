using System;

class SpringSeason7
{
    static void Main()
    {
        Console.Write("Enter month: ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20)) //check conditin
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
