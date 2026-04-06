using System;

class Quadratic11
{
    static double[] FindRoots(double a,double b,double c)//methdo to find roots 
    {
        double delta=b*b-4*a*c;//discriminant

        if(delta>0)//teo real roots
            return new double[]{(-b+Math.Sqrt(delta))/(2*a),(-b-Math.Sqrt(delta))/(2*a)};
        else if(delta==0)//one real root
            return new double[]{-b/(2*a)};
        else// no real roots
            return new double[]{}; //emty arr
    }

    static void Main()
    {
        Console.Write("a: "); double a=Convert.ToDouble(Console.ReadLine());//inpoutthe coefficients
        Console.Write("b: "); double b=Convert.ToDouble(Console.ReadLine());
        Console.Write("c: "); double c=Convert.ToDouble(Console.ReadLine());

        double[] roots=FindRoots(a,b,c);

        if(roots.Length==0)
            Console.WriteLine("No real roots");
        else if(roots.Length==1)
            Console.WriteLine($"One root: x={roots[0]:F2}");
        else
            Console.WriteLine($"Two roots: x1={roots[0]:F2}, x2={roots[1]:F2}");
    }
}
