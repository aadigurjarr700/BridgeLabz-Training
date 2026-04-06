using System;

class DateArithmetic2
{
    static void Main()
    {
        Console.WriteLine("Enter a date (yyyy-MM-dd):");
        string input=Console.ReadLine();//input
        DateTime date=DateTime.Parse(input);//convert to DateTime

        //add 7 days
        date=date.AddDays(7);
        //add 1 month
        date=date.AddMonths(1);
        //add 2 years
        date=date.AddYears(2);
        Console.WriteLine("After adding 7 days, 1 month, 2 years: "+date.ToString("yyyy-MM-dd"));

        //subtract 3 weeks (21 days)
        date=date.AddDays(-21);
        Console.WriteLine("After subtracting 3 weeks: "+date.ToString("yyyy-MM-dd"));
    }
}
