using System;

class CelsiusToFahrenheit
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());//take input from user for temperature in Celsius

        double fahrenheit = (celsius * 9 / 5) + 32;//calculate temperature in Fahrenheit

        Console.WriteLine("Temperature in Fahrenheit = " + fahrenheit);//display temperature in Fahrenheit
    }
}
