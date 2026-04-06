using System;

class IntOperation2
{
    static void Main()
    {
        int a,b,c;                                //inputs
        Console.WriteLine("Enter a:");
        a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter b:");
        b=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter c:");
        c=Convert.ToInt32(Console.ReadLine());

        int op1=a+b*c;                            //a + b*c
        int op2=a*b+c;                            //a*b + c
        int op3=c+a/b;                            //c + a/b
        int op4=a%b+c;                            //a % b + c

        Console.WriteLine("The results of Int Operations are "+op1+", "+op2+", "+op3+", and "+op4); //output
    }
}

