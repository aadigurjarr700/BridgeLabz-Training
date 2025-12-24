using System;

class Calendar8
{
    public static string GetMonthName(int month)//get month nqame 
    {
        string[] months = { "January","February","March","April","May","June",
                            "July","August","September","October","November","December" };
        return months[month - 1];
    }

    //check leap year
    public static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    //get number of days in month
    public static int GetDaysInMonth(int month, int year)
    {
        int[] days = { 31,28,31,30,31,30,31,31,30,31,30,31 };
        if (month == 2 && IsLeapYear(year))
        {
            return 29;
        }
        return days[month - 1];
    }

    //get  first day of month (0=Sun, 1=Mon,...)
    public static int GetFirstDay(int month, int year)
    {
        int m = month;
        int y = year;
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0/4 - y0/100 + y0/400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (1 + x + 31*m0/12) % 7;
        return d0;
    }

    public static void DisplayCalendar(int month, int year)
    {
        Console.WriteLine("   " + GetMonthName(month) + " " + year);
        Console.WriteLine("Su Mo Tu We Th Fr Sa");

        int firstDay = GetFirstDay(month, year);
        int days = GetDaysInMonth(month, year);

        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("   ");
        }

        //print days
        for (int day = 1; day <= days; day++)
        {
            Console.Write(day.ToString().PadLeft(2) + " ");
            if ((day + firstDay) % 7 == 0)
                Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        DisplayCalendar(month, year);
    }
}
