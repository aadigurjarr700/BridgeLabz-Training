using System;

class PoundsToKg12
{
    static void Main()
    {
        double weightPounds;
        Console.WriteLine("Enter weight in pounds:");
        weightPounds=Convert.ToDouble(Console.ReadLine());

        double weightKg=weightPounds/2.2;           //convert

        Console.WriteLine("The weight of the person in pounds is "+weightPounds+" and in kg is "+weightKg); //output
    }
}
