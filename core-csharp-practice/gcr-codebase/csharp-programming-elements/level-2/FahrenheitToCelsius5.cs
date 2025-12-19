using System;

class FahrenheitToCelsius5
{
    static void Main()
    {
        double fahrenheit;
        Console.WriteLine("Enter temperature in Fahrenheit:");
        fahrenheit=Convert.ToDouble(Console.ReadLine());//take input from user

        double celsius=(fahrenheit-32)*5/9;      //conversion

        Console.WriteLine("The "+fahrenheit+" Fahrenheit is "+celsius+" Celsius"); //output
    }
}
