using System;

class VolumeOfEarth7
{
    static void Main()
    {
        double radiusKm=6378;                 //earth radius in km
        double pi=3.14159;                    //pi value

        double volumeKm=(4.0/3)*pi*Math.Pow(radiusKm,3); //volume in km³
        double radiusMiles=radiusKm/1.6;      //convert radius to miles
        double volumeMiles=(4.0/3)*pi*Math.Pow(radiusMiles,3); //volume in miles³

        Console.WriteLine("The volume of earth in cubic kilometers is "+volumeKm+
                          " and cubic miles is "+volumeMiles); //output
    }
}
