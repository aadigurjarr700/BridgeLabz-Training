using System;

class UnitConvertor4
{
    public static double ConvertKmToMiles(double km)//method to convert km to miles
    {
        return km*0.621371;
    }

    public static double ConvertMilesToKm(double miles)//method to convert miles to km
    {
        return miles*1.60934;
    }

    public static double ConvertMetersToFeet(double meters)//method to convert meters to feet
    {
        return meters*3.28084;
    }

    public static double ConvertFeetToMeters(double feet)//method to convert feet to meters
    {
        return feet*0.3048;
    }

    static void Main()
    {
        Console.WriteLine(ConvertKmToMiles(5));
        Console.WriteLine(ConvertMilesToKm(3));
        Console.WriteLine(ConvertMetersToFeet(10));
        Console.WriteLine(ConvertFeetToMeters(30));
    }
}
