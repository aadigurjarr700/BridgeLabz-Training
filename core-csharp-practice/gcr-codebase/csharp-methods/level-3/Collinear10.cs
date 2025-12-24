using System;

class Collinear10
{
    public static bool AreCollinearSlope(double x1, double y1, double x2, double y2, double x3, double y3) // Check collinear using slopes
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);
        return slopeAB == slopeBC && slopeAB == slopeAC;
    }
    public static bool AreCollinearArea(double x1, double y1, double x2, double y2, double x3, double y3)
    // Check collinear using area of triangle
    {
        double area = 0.5 * (x1*(y2 - y3) + x2*(y3 - y1) + x3*(y1 - y2));
        return area == 0;
    }

    static void Main()
    {
        Console.Write("Enter x1, y1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x2, y2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x3, y3: ");
        double x3 = Convert.ToDouble(Console.ReadLine());
        double y3 = Convert.ToDouble(Console.ReadLine());

        bool collinearSlope = AreCollinearSlope(x1, y1, x2, y2, x3, y3);
        bool collinearArea = AreCollinearArea(x1, y1, x2, y2, x3, y3);

        Console.WriteLine("Collinear by slope? " + collinearSlope);
        Console.WriteLine("Collinear by area? " + collinearArea);
    }
}
