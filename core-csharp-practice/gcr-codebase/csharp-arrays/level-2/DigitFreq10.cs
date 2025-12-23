using System;

class DigitFreq10{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int temp = num;
        int count = 0;

        //count  thr digts
        while (temp != 0)
        {
            temp /= 10;
            count++;
        }

        int[] digits = new int[count];//store thr  digits
        int[] freq = new int[10];// freqncy arr 0-9

        temp = num;
        int index = 0;

        while (temp != 0)
        {
            digits[index++] = temp % 10;
            temp /= 10;
        }
        //clalculate thr frequency
        for (int i = 0; i < index; i++)
        {
            freq[digits[i]]++;
        }
        //show the frequency
        Console.WriteLine("Digit\tFrequency");
        for (int i = 0; i < 10; i++)
        {
            if (freq[i] > 0)
                Console.WriteLine(i + "\t" + freq[i]);
        }
    }
}
