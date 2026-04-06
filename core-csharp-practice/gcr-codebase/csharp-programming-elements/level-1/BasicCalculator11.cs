using System;

class BasicCalculator11
{
    static void Main()
    {
        double number1;                          //first number
        double number2;                          //second number

        Console.WriteLine("Enter first number:");
        number1=Convert.ToDouble(Console.ReadLine()); //input

        Console.WriteLine("Enter second number:");
        number2=Convert.ToDouble(Console.ReadLine()); //input

        double addition=number1+number2;         //addition
        double subtraction=number1-number2;      //subtraction
        double multiplication=number1*number2;   //multiplication
        double division=number1/number2;          //division

        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+number1+" and "+number2+" is "+addition+", "+subtraction+", "+multiplication+", and "+division); //output
    }
}
