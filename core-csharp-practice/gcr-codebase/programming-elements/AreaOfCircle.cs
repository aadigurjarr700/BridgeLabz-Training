using System;

class AreaOfCircle
{
    static void Main(string[] args)
    {
        Console.Write("Enter radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());//take input from user for radius

        double area = Math.PI * radius * radius;//calculate area of circle

        Console.WriteLine("Area of the circle = " + area);//display area
    }
}
