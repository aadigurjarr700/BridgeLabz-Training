using System;

class NumberChecker5
{
    //check prime number
    public static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    //check neon number
    public static bool IsNeon(int n)
    {
        int square = n * n;
        int sum = 0;
        while (square > 0)
        {
            sum += square % 10;
            square /= 10;
        }
        return sum == n;
    }

    //check spy number
    public static bool IsSpy(int n)
    {
        int sum = 0, product = 1, num = n;
        while (num > 0)
        {
            int d = num % 10;
            sum += d;
            product *= d;
            num /= 10;
        }
        return sum == product;
    }

    //check automorphic number
    public static bool IsAutomorphic(int n)
    {
        int square = n * n;
        int len = n.ToString().Length;
        int lastDigits = square % (int)Math.Pow(10, len);
        return lastDigits == n;
    }

    //check buzz number
    public static bool IsBuzz(int n)
    {
        if (n % 7 == 0)
        {
            return true;
        }
        else if (n % 10 == 7)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        int n = 7;//number

        Console.WriteLine("Prime? " + IsPrime(n));
        Console.WriteLine("Neon? " + IsNeon(n));
        Console.WriteLine("Spy? " + IsSpy(n));
        Console.WriteLine("Automorphic? " + IsAutomorphic(n));
        Console.WriteLine("Buzz? " + IsBuzz(n));
    }
}
