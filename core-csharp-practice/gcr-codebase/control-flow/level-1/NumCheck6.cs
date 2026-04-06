using System;

class NumCheck6
{
    static void Main()
    {
        int number; // taek the input

        Console.WriteLine("Enter a number:");
        number=Convert.ToInt32(Console.ReadLine()); 

        if(number>0)
            Console.WriteLine("Positive");
        else if(number<0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");
    }
}
