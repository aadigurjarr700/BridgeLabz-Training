using System;

class AthleteRun9
{
    static void Main()
    {
        double side1, side2, side3;
        Console.WriteLine("Enter side1 in meters:");
        side1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter side2 in meters:");
        side2=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter side3 in meters:");
        side3=Convert.ToDouble(Console.ReadLine());

        double perimeter=side1+side2+side3;           //perimeter
        double totalDistance=5000;                    //5 km = 5000 meters
        double rounds=totalDistance/perimeter;       //rounds

        Console.WriteLine("The total number of rounds the athlete will run is "+rounds); //output
    }
}
