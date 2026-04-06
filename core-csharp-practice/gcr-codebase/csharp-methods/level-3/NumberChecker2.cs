using System;

class NumberChecker2{
    public static int CountDigits(int n) => n.ToString().Length;//count digits
    public static int[] GetDigits(int n)//get didgist as array 
    {
        string s = n.ToString();
        int[] digits = new int[s.Length];
        for (int i = 0; i < s.Length; i++) digits[i] = s[i] - '0';
        return digits;
    }
    public static bool IsDuck(int n)//cehck it is duck or not
    {
        foreach (int d in GetDigits(n))
            if (d != 0) return true;
        return false;
    }
    public static bool IsArmstrong(int n)//cekck armstriong nuymbe r
    {
        int[] d = GetDigits(n);
        int sum = 0;
        int power = d.Length;
        foreach (int x in d) sum += (int)Math.Pow(x, power);
        return sum == n;
    }

    //largest adn second largest 
    public static (int, int) Largest2(int n)
    {
        int[] d = GetDigits(n);
        int max1 = int.MinValue, max2 = int.MinValue;
        foreach (int x in d)
        {
            if (x > max1) { max2 = max1; max1 = x; }
            else if (x > max2) max2 = x;
        }
        return (max1, max2);
    }

    //smallest and second smallest
    public static (int, int) Smallest2(int n)
    {
        int[] d = GetDigits(n);
        int min1 = int.MaxValue, min2 = int.MaxValue;
        foreach (int x in d)
        {
            if (x < min1) { min2 = min1; min1 = x; }
            else if (x < min2) min2 = x;
        }
        return (min1, min2);
    }

    static void Main()
    {
        int n = 153; //number
        Console.WriteLine("Digits count: " + CountDigits(n));
        Console.WriteLine("Digits: " + string.Join(",", GetDigits(n)));
        Console.WriteLine("Duck? " + IsDuck(n));
        Console.WriteLine("Armstrong? " + IsArmstrong(n));
        var l = Largest2(n);
        Console.WriteLine($"Largest: {l.Item1}, Second Largest: {l.Item2}");
        var s = Smallest2(n);
        Console.WriteLine($"Smallest: {s.Item1}, Second Smallest: {s.Item2}");
    }
}
