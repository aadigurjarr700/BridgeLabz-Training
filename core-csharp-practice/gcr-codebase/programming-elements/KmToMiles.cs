using System;

class KmToMiles
{
    static void Main(string[] args)
    {
        Console.Write("Enter distance in kilometers: ");
        double kilometers = Convert.ToDouble(Console.ReadLine());//take input from user for distance in kilometers

        double miles = kilometers * 0.621371;//calculate distance in miles

        Console.WriteLine("Distance in miles = " + miles);//dispay distance in miles
    }
}
