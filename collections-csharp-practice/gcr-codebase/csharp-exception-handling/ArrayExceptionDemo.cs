using System;

class ArrayExceptionDemo
{
    static void Main()
    {
        try
        {
            int[] numbers = { 5, 10, 15 };

            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Value: " + numbers[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
    }
}
