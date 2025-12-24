using System;

class LeapYearCheck3
{
    static bool IsLeapYear(int year)//methdo to check tehr leap yaer 
    {
        if(year<1582)return false;
        return (year%4==0 && year%100!=0)||year%400==0;
    }

    static void Main()
    {
        Console.Write("Enter year: ");
        int year=Convert.ToInt32(Console.ReadLine());//take teh input from usr 

        if(IsLeapYear(year))
            Console.WriteLine("Year is a Leap Year");
        else
            Console.WriteLine("Year is not a Leap Year");
    }
}
