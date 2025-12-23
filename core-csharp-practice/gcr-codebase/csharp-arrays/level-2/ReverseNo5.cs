using System;

class ReverseNo5
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int original = num;

        //Count thr  digits
        int temp = num;
        int count = 0;
        while (temp != 0)
        {
            count++;
            temp /= 10;
        }

        int[] digits = new int[count];//arr to store digits

        for (int i = 0; i < count; i++)
        {
            digits[i] = num % 10;
            num /= 10;
        }

        Console.Write("Reversed number: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(digits[i]);
        }
    }
}
