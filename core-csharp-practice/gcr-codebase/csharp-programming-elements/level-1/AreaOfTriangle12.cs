using System;

class AreaOfTriangle12
{
    static void Main()
    {
        double baseValue;                         //base
        double heightValue;                       //height

        Console.WriteLine("Enter base:");
        baseValue=Convert.ToDouble(Console.ReadLine()); //input

        Console.WriteLine("Enter height:");
        heightValue=Convert.ToDouble(Console.ReadLine()); //input

        double areaInInches=0.5*baseValue*heightValue; //area in sq inches
        double areaInCm=areaInInches*6.4516;       //inches to cm

        Console.WriteLine("The area of triangle in square inches is "+areaInInches+" and in square centimeters is "+areaInCm); //output
    }
}
