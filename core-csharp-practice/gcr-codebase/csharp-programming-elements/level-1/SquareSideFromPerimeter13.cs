using System;

class SquareSideFromPerimeter13
{
    static void Main()
    {
        double perimeter;                         //perimeter

        Console.WriteLine("Enter perimeter:");
        perimeter=Convert.ToDouble(Console.ReadLine()); //input

        double side=perimeter/4;                  //side calculation

        Console.WriteLine("The length of the side is "+side+" whose perimeter is "+perimeter); //output
    }
}
