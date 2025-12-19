using System;

class TripDistance8
{
    static void Main()
    {
        string name, fromCity, viaCity, toCity;
        double fromToVia, viaToFinalCity, timeTaken;

        Console.WriteLine("Enter your name:");
        name=Console.ReadLine();
        Console.WriteLine("Enter fromCity:");
        fromCity=Console.ReadLine();
        Console.WriteLine("Enter viaCity:");
        viaCity=Console.ReadLine();
        Console.WriteLine("Enter toCity:");
        toCity=Console.ReadLine();
        Console.WriteLine("Enter distance from fromCity to viaCity in miles:");
        fromToVia=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter distance from viaCity to toCity in miles:");
        viaToFinalCity=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter time taken in hours:");
        timeTaken=Convert.ToDouble(Console.ReadLine());

        double totalDistance=fromToVia+viaToFinalCity; //total
        double speed=totalDistance/timeTaken;          //speed

        Console.WriteLine("The results of the trip are: Total Distance "+totalDistance+
                          " miles, Time "+timeTaken+" hours, Average Speed "+speed+" mph"); //output
    }
}
