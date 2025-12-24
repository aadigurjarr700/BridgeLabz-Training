using System;

class TriangularPark4
{
    static double CalculateRounds(double a,double b,double c)//mathod to claculaet the rounds 
    {
        double perimeter=a+b+c;
        return 5000/perimeter;
    }

    static void Main()
    {
        Console.Write("Enter side 1 (m): ");
        double side1=Convert.ToDouble(Console.ReadLine());//taek inpt from user

        Console.Write("Enter side 2 (m): ");
        double side2=Convert.ToDouble(Console.ReadLine());//take input from user

        Console.Write("Enter side 3 (m): ");
        double side3=Convert.ToDouble(Console.ReadLine());//trake input form user 

        double rounds=CalculateRounds(side1,side2,side3);//calculate the rouynds

        Console.WriteLine($"Number of rounds to complete 5 km run: {rounds}");
    }
}
