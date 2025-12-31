using System;

class Circle
{
    double radius;

    // Default constructor calls parameterized one
    Circle():this(1){}

    // Constructor with radius
    Circle(double r)
    {
        radius=r;
    }

    // Calculate area
    void Area()
    {
        Console.WriteLine("Area of circle: "+(3.14*radius*radius));
    }

    static void Main()
    {
        // User input
        Console.Write("Enter radius: ");
        double r=Convert.ToDouble(Console.ReadLine());

        Circle c=new Circle(r);
        c.Area();
    }
}
