using System;

class NumberChecker3
{
    public static int CountDigits(int n)//count digits
    {
        return n.ToString().Length;
    }
    public static int SumDigits(int n)//count the digist 
    {
        int sum = 0;
        int num = n;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
    public static int SumSquares(int n)//sum of squares iof fdigist 
    {
        int sum = 0;
        int num = n;
        while (num > 0)
        {
            int d = num % 10;
            sum += d * d;
            num /= 10;
        }
        return sum;
    }
    public static bool IsHarshad(int n)//check if harhsad number 
    {
        if (n % SumDigits(n) == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static void DigitFrequency(int n)//print freq oif digtits 
    {
        int[] freq = new int[10];
        int num = n;
        while (num > 0)
        {
            freq[num % 10]++;
            num /= 10;
        }
        Console.WriteLine("Digit frequencies:");
        for (int i = 0; i < 10; i++)
        {
            if (freq[i] > 0)
            {
                Console.WriteLine(i + ": " + freq[i]);
            }
        }
    }

    static void Main()
    {
        int n = 21; //number

        Console.WriteLine("Digits count: " + CountDigits(n));
        Console.WriteLine("Sum of digits: " + SumDigits(n));
        Console.WriteLine("Sum of squares: " + SumSquares(n));
        Console.WriteLine("Harshad? " + IsHarshad(n));
        DigitFrequency(n);
    }
}
