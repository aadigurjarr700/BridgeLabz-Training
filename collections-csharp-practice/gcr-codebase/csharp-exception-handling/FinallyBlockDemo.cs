using System;

class FinallyBlockDemo
{
    static void Main()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Result: " + (x / y));
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Operation completed");
        }
    }
}
