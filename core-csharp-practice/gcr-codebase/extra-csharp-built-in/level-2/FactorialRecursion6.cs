using System;

class FactorialRecursion6
{
    //read thr take input
    static int ReadNumber()
    {
        Console.WriteLine("Enter a number:");
        return int.Parse(Console.ReadLine());
    }

    //recursive factorial
    static int Factorial(int n)
    {
        if(n<=1) return 1;
        return n*Factorial(n-1);
    }

    //thr output
    static void ShowResult(int n,int result)
    {
        Console.WriteLine("Factorial of "+n+" is "+result);
    }

    static void Main()
    {
        int num=ReadNumber();
        int fact=Factorial(num);
        ShowResult(num,fact);
    }
}
