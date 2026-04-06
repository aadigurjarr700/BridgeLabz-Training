using System;

class AvgOfThreeNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());//take input from user for first number

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());//take input from user for second number

        Console.Write("Enter third number: ");
        double num3 = Convert.ToDouble(Console.ReadLine());//take input from user for third number

        double average = (num1 + num2 + num3) / 3;//calculate average of three numbers

        Console.WriteLine("Average = " + average);//display average
    }
}
