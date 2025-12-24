using System;
class FibonacciSeries1{
    static void Main()
    {
        int n;
        int a=0,b=1,c;
        Console.Write("Enter thr range:");
        n=Convert.ToInt32(Console.ReadLine());
        if(n<=0)
        {
            Console.WriteLine("invalid range");
            return;
        }
        Console.Write(a+" ");
        if(n>1)
            Console.Write(b+" ");

        for(int i=3;i<=n;i++)
        {
            c=a+b;
            Console.WriteLine(c+" ");
            a=b;
            b=c;
        }
    }
}