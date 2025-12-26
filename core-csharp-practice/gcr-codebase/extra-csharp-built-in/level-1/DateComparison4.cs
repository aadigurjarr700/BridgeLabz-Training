using System;

class DateComparison4
{
    static void Main()
    {
        Console.WriteLine("Enter first date (yyyy-MM-dd):");
        DateTime date1=DateTime.Parse(Console.ReadLine());//first date

        Console.WriteLine("Enter second date (yyyy-MM-dd):");
        DateTime date2=DateTime.Parse(Console.ReadLine());//second date

        int result=DateTime.Compare(date1,date2);//compare

        if(result<0) Console.WriteLine("First date is before second date");
        else if(result>0) Console.WriteLine("First date is after second date");
        else Console.WriteLine("Both dates are the same");
    }
}
