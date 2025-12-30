using System;

class Circle
{
    // variable to store radius
    double radius;

    // constant value of PI
    const double PI = 3.14;

    // method to take radius input
    public void TakeRadius()
    {
        Console.Write("Enter radius of circle: ");
        radius = Convert.ToDouble(Console.ReadLine());
    }

    // method to calculate area
    public double CalculateArea()
    {
        return PI * radius * radius;
    }

    // method to calculate circumference
    public double CalculateCircumference()
    {
        return 2 * PI * radius;
    }

    // method to display results
    public void DisplayResult()
    {
        Console.WriteLine("\nCircle Results:");
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }
}

class Program
{
    static void Main()
    {
        // creating circle object
        Circle c = new Circle();

        // taking radius input
        c.TakeRadius();

        // displaying area and circumference
        c.DisplayResult();
    }
}
