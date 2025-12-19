using System;

class DoubleOpt3
{
    static void Main()
    {
        double a,b,c;                             //inputs
        Console.WriteLine("Enter a:");
        a=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter b:");
        b=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter c:");
        c=Convert.ToDouble(Console.ReadLine());

        double op1=a+b*c;
        double op2=a*b+c;
        double op3=c+a/b;
        double op4=a%b+c;

        Console.WriteLine("The results of Double Operations are "+op1+", "+op2+", "+op3+", and "+op4); //output
    }
}
