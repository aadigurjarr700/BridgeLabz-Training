using System;

class UnitConverter5
{
    public static double ConvertYardsToFeet(double yards)//convert yards to feet
    {
        return yards*3;
    }
    public static double ConvertFeetToYards(double feet)//convert feet to yards
    {
        return feet*0.333333;
    }
    public static double ConvertMetersToInches(double meters)//convert meters to inches
    {
        return meters*39.3701;
    }
    public static double ConvertInchesToMeters(double inches)//convert inches to meters
    {
        return inches*0.0254;
    }
    public static double ConvertInchesToCentimeters(double inches)// Convert inches to centimeters
    {
        return inches*2.54;
    }

    static void Main()
    {
        Console.WriteLine(ConvertYardsToFeet(2));
        Console.WriteLine(ConvertFeetToYards(6));
        Console.WriteLine(ConvertMetersToInches(1));
        Console.WriteLine(ConvertInchesToMeters(10));
        Console.WriteLine(ConvertInchesToCentimeters(5));
    }
}
