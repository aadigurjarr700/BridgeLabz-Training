using System;

class VolumeOfCylinder
{
    static void Main(string[] args)
    {
        Console.Write("Enter radius of the cylinder: ");
        double radius = Convert.ToDouble(Console.ReadLine());//take input from user for radius

        Console.Write("Enter height of the cylinder: ");
        double height = Convert.ToDouble(Console.ReadLine());//take input from user for height

        double volume = Math.PI * radius * radius * height;//calculate volume of cylinder

        Console.WriteLine("Volume of the cylinder = " + volume);//dispay volume
    }
}
