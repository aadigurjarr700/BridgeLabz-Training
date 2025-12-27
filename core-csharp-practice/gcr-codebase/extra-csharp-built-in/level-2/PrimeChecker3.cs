using System;

class PrimeChecker3
{
    //check thr prime logic
    static bool IsPrime(int num)
    {
        if(num<=1) return false;
        for(int i=2;i*i<=num;i++)
        {
            if(num%i==0) return false;
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int value=int.Parse(Console.ReadLine());

        if(IsPrime(value)) Console.WriteLine(value+" is a prime number");
        else Console.WriteLine(value+" is not a prime number");
    }
}
