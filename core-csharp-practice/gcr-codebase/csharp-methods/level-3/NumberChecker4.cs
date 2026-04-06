using System;

class NumberChecker4
{
    public static int CountDigits(int n)//coutjn digits 
    {
        return n.ToString().Length;
    }
    public static int[] GetDigits(int n)//get digist array 
    {
        int len = CountDigits(n);
        int[] digits = new int[len];
        int num = n;
        for (int i = len - 1; i >= 0; i--)
        {
            digits[i] = num % 10;
            num /= 10;
        }
        return digits;
    }
    public static int[] ReverseDigits(int n)//revers edigits array 
    {
        int[] digits = GetDigits(n);
        int len = digits.Length;
        int[] rev = new int[len];
        for (int i = 0; i < len; i++)
        {
            rev[i] = digits[len - 1 - i];
        }
        return rev;
    }
    public static bool AreArraysEqual(int[] a, int[] b)//compare two arrays
    {
        if (a.Length != b.Length)
        {
            return false;
        }
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
            {
                return false;
            }
        }
        return true;
    }

    //check palindrome
    public static bool IsPalindrome(int n)
    {
        int[] original = GetDigits(n);
        int[] reversed = ReverseDigits(n);
        return AreArraysEqual(original, reversed);
    }

    //check duck number
    public static bool IsDuck(int n)
    {
        int[] digits = GetDigits(n);
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] != 0)
            {
                return true;
            }
        }
        return false;
    }

    static void Main()
    {
        int n = 12321; //number

        Console.WriteLine("Digits count: " + CountDigits(n));
        Console.WriteLine("Digits: " + string.Join(",", GetDigits(n)));
        Console.WriteLine("Reversed digits: " + string.Join(",", ReverseDigits(n)));
        Console.WriteLine("Palindrome? " + IsPalindrome(n));
        Console.WriteLine("Duck number? " + IsDuck(n));
    }
}
