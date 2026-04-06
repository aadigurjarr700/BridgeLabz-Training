using System;

class KMtoMile8
{
    static void Main()
    {
        double km;                  //distance in km
        Console.WriteLine("Enter distance in km:");
        km=Convert.ToDouble(Console.ReadLine()); //user input

        double miles=km/1.6;                   //km to miles

        Console.WriteLine("The total miles is "+miles+" mile for the given "+km+" km"); //output
    }
}
