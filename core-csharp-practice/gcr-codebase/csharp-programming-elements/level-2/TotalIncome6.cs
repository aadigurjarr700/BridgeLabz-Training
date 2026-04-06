using System;

class TotalIncome6
{
    static void Main()
    {
        double salary, bonus;
        Console.WriteLine("Enter salary:");
        salary=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter bonus:");
        bonus=Convert.ToDouble(Console.ReadLine());

        double totalIncome=salary+bonus;         //total income

        Console.WriteLine("The salary is INR "+salary+" and bonus is INR "+bonus+". Hence Total Income is INR "+totalIncome); //output
    }
}
