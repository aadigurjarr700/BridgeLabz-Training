using System;

class FeetToYardsMiles14
{
    static void Main()
    {
        double distanceInFeet;                    //distance in feet

        Console.WriteLine("Enter distance in feet:");
        distanceInFeet=Convert.ToDouble(Console.ReadLine()); //input

        double yards=distanceInFeet/3;            //feet to yards
        double miles=yards/1760;                  //yards to miles

        Console.WriteLine("Distance in feet is "+distanceInFeet+" while in yards is "+yards+" and miles is "+miles); //output
    }
}
