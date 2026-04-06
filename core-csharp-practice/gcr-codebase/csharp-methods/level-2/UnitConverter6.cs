using System;

class UnitConverter6
{
    public static double ConvertFahrenheitToCelsius(double fahrenheit)//convert Farenheit to celsus
    {
        return (fahrenheit-32)*5/9;
    }
    public static double ConvertCelsiusToFahrenheit(double celsius)//convert celsius to farenheit
    {
        return (celsius*9/5)+32;
    }
    public static double ConvertPoundsToKilograms(double pounds)//covrt pound to kg 
    {
        return pounds*0.453592;
    }
    public static double ConvertKilogramsToPounds(double kg)//convert kg to pound
    {
        return kg*2.20462;
    }
    public static double ConvertGallonsToLiters(double gallons)//convert gallons to litres
    {
        return gallons*3.78541;
    }
    public static double ConvertLitersToGallons(double liters)//convert litrs to gallons
    {
        return liters*0.264172;
    }

    static void Main()
    {
        Console.WriteLine(ConvertFahrenheitToCelsius(100));
        Console.WriteLine(ConvertCelsiusToFahrenheit(37.78));
        Console.WriteLine(ConvertPoundsToKilograms(150));
        Console.WriteLine(ConvertKilogramsToPounds(68));
        Console.WriteLine(ConvertGallonsToLiters(5));
        Console.WriteLine(ConvertLitersToGallons(10));
    }
}
