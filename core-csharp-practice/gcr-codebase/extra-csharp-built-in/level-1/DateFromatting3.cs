using System;

class DateFormatting3
{
    static void Main()
    {
        DateTime today=DateTime.Now;//current date

        Console.WriteLine("Format dd/MM/yyyy: "+today.ToString("dd/MM/yyyy"));
        Console.WriteLine("Format yyyy-MM-dd: "+today.ToString("yyyy-MM-dd"));
        Console.WriteLine("Format EEE, MMM dd, yyyy: "+today.ToString("ddd, MMM dd, yyyy"));
    }
}
