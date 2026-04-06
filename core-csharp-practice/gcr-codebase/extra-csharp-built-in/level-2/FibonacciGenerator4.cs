using System;

class FibonacciGenerator4
{
    //print thr fibonacci series
    static void PrintFibonacci(int terms)
    {
        int a=0,b=1;
        for(int i=0;i<terms;i++)
        {
            Console.Write(a+" ");
            int next=a+b;
            a=b;
            b=next;
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Enter number of terms:");
        int n=int.Parse(Console.ReadLine());//take teh input from user 
        PrintFibonacci(n);//call thr  method
    }
}
