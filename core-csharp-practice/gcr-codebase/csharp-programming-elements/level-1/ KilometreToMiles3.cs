using System;

class KilometreToMiles3
{
    static void Main()
    {
        //Distance in kilometers
        double distanceInKm=10.8;

        //Conversion factor
        double kmToMiles=1.6;

        //Convert km to miles
        double distanceInMiles=distanceInKm*kmToMiles;

        //Display result
        Console.WriteLine("The distance "+distanceInKm+" km in miles is "+distanceInMiles);
    }
}
