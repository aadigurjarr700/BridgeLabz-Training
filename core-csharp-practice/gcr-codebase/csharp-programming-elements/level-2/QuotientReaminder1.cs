using System;

class QuotientRemainder1
{
    static void Main()
    {
        int number1, number2;                     //input numbers
        Console.WriteLine("Enter first number:");
        number1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        number2=Convert.ToInt32(Console.ReadLine());

        int quotient=number1/number2;            //division
        int remainder=number1%number2;           //modulus

        Console.WriteLine("The Quotient is "+quotient+" and Remainder is "+remainder+" of two numbers "+number1+" and "+number2); //output
    }
}
