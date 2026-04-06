using System;

class PowerCalculation
{
    static void Main(string[] args)
    {
        Console.Write("Enter the base number: ");
        double baseNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        double exponent = Convert.ToDouble(Console.ReadLine());

        double result = Math.Pow(baseNum, exponent);

        Console.WriteLine("Result = " + result);
    }
}
