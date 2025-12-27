using System;

class GcdLcmCalculator7
{
    //read thr number
    static int ReadNumber(string msg)
    {
        Console.WriteLine(msg);
        return int.Parse(Console.ReadLine());
    }

    //logic of gcd 
    static int GCD(int a,int b)
    {
        while(b!=0)
        {
            int temp=b;
            b=a%b;
            a=temp;
        }
        return a;
    }

    //lcm logic
    static int LCM(int a,int b)
    {
        return (a*b)/GCD(a,b);
    }

    static void Main()
    {
        int x=ReadNumber("Enter first number:");
        int y=ReadNumber("Enter second number:");

        int gcd=GCD(x,y);
        int lcm=LCM(x,y);

        Console.WriteLine("GCD: "+gcd);
        Console.WriteLine("LCM: "+lcm);
    }
}
