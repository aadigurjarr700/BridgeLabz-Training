using System;
class SimpleInterest
{
    static void Main(string[] args)
    {
        Console.Write("Enter principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());//take input from user for principal amount

        Console.Write("Enter rate of interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());//take input from user for rate of interest

        Console.Write("Enter time in years: ");
        double time = Convert.ToDouble(Console.ReadLine());//take input from user for time in years

        double simpleInterest = (principal * rate * time) / 100;//calculate simple interest

        Console.WriteLine("Simple Interest = " + simpleInterest);//dispay simple interest
    }
}