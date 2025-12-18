using System;

class PerimeterOfRectangle
{
    static void Main(string[] args)
    {
        Console.Write("Enter length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());//take input from user for length

        Console.Write("Enter breadth of the rectangle: ");
        double breadth = Convert.ToDouble(Console.ReadLine());//take input from user for breadth

        double perimeter = 2 * (length + breadth);//calculate perimeter of rectangle

        Console.WriteLine("Perimeter of the rectangle = " + perimeter);//dispay perimeter
    }
}
