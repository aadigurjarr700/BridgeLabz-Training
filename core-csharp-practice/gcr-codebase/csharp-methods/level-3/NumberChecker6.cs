using System;

class NumberChecker6
{
    public static int[] Factors(int n)//find factors fo n 
    {
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }
        return factors;
    }
    public static int GreatestFactor(int n)//gratest factor 
    {
        int[] factors = Factors(n);
        int max = factors[0];
        for (int i = 1; i < factors.Length; i++)
        {
            if (factors[i] > max)
            {
                max = factors[i];
            }
        }
        return max;
    }
    public static int SumFactors(int n)//sum of factors 
    {
        int sum = 0;
        int[] factors = Factors(n);
        for (int i = 0; i < factors.Length; i++)
        {
            sum += factors[i];
        }
        return sum;
    }
    public static int ProductFactors(int n)//product of factors 
    {
        int prod = 1;
        int[] factors = Factors(n);
        for (int i = 0; i < factors.Length; i++)
        {
            prod *= factors[i];
        }
        return prod;
    }

    public static double ProductCubeFactors(int n)//product of cube of factors 
    {
        double prod = 1;
        int[] factors = Factors(n);
        for (int i = 0; i < factors.Length; i++)
        {
            prod *= Math.Pow(factors[i], 3);
        }
        return prod;
    }

    //perfect number
    public static bool IsPerfect(int n)
    {
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0) sum += i;
        }
        return sum == n;
    }

    //abundant number
    public static bool IsAbundant(int n)
    {
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0) sum += i;
        }
        return sum > n;
    }

    //deficient number
    public static bool IsDeficient(int n)
    {
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0) sum += i;
        }
        return sum < n;
    }

    // factorial
    public static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }

    //strong number
    public static bool IsStrong(int n)
    {
        int sum = 0;
        int num = n;
        while (num > 0)
        {
            int d = num % 10;
            sum += Factorial(d);
            num /= 10;
        }
        return sum == n;
    }

    static void Main()
    {
        int n = 28; //number

        Console.WriteLine("Factors: " + string.Join(",", Factors(n)));
        Console.WriteLine("Greatest factor: " + GreatestFactor(n));
        Console.WriteLine("Sum factors: " + SumFactors(n));
        Console.WriteLine("Product factors: " + ProductFactors(n));
        Console.WriteLine("Product of cube of factors: " + ProductCubeFactors(n));
        Console.WriteLine("Perfect? " + IsPerfect(n));
        Console.WriteLine("Abundant? " + IsAbundant(n));
        Console.WriteLine("Deficient? " + IsDeficient(n));
        Console.WriteLine("Strong? " + IsStrong(n));
    }
}
