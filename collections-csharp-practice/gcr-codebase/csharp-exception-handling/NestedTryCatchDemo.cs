using System;

class NestedTryCatchDemo
{
    static void Main()
    {
        int[] arr = { 10, 20, 30 };

        try
        {
            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());

            try
            {
                Console.Write("Enter divisor: ");
                int div = int.Parse(Console.ReadLine());

                Console.WriteLine(arr[index] / div);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid array index!");
        }
    }
}
