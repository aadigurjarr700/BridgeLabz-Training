using System;

class TemperatureConvertor8
{
    //fahrenheit to celsius
    static double FahrenheitToCelsius(double f)
    {
        return (f-32)*5/9;
    }

    //celsius to fahrenheit
    static double CelsiusToFahrenheit(double c)
    {
        return (c*9/5)+32;
    }

    static void Main()
    {
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        int choice=int.Parse(Console.ReadLine());

        if(choice==1)
        {
            Console.WriteLine("Enter temperature in Fahrenheit:");
            double f=double.Parse(Console.ReadLine());
            Console.WriteLine("Celsius: "+FahrenheitToCelsius(f));
        }
        else if(choice==2)
        {
            Console.WriteLine("Enter temperature in Celsius:");
            double c=double.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit: "+CelsiusToFahrenheit(c));
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }
}
