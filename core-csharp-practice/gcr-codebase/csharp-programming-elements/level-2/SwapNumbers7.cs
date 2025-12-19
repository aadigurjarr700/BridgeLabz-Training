using System;

class SwapNumbers7
{
    static void Main()
    {
        double number1, number2;
        Console.WriteLine("Enter number1:");
        number1=Convert.ToDouble(Console.ReadLine()); //take input from user
        Console.WriteLine("Enter number2:");
        number2=Convert.ToDouble(Console.ReadLine());//take input from user

        double temp=number1;                     //swap
        number1=number2;
        number2=temp;

        Console.WriteLine("The swapped numbers are "+number1+" and "+number2); //output
    }
}
