using System;

class MaxOfThree2
{
    //rea dthr integer input
    static int ReadNumber(string msg)
    {
        Console.WriteLine(msg);
        return int.Parse(Console.ReadLine());
    }

    //find trh  maximum value
    static int FindMax(int a,int b,int c)
    {
        int max=a;
        if(b>max) max=b;
        if(c>max) max=c;
        return max;
    }

    static void Main()
    {
        int n1=ReadNumber("Enter first number:");
        int n2=ReadNumber("Enter second number:");
        int n3=ReadNumber("Enter third number:");

        int result=FindMax(n1,n2,n3);
        Console.WriteLine("Maximum number: "+result);
    }
}
