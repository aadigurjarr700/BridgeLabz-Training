using System;

class LargestDigits3
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine()); //take the inpopt

        int[] digits = new int[10];//array to store digits
        int index = 0;

        //stre thr  digits in array
        while (num != 0)
        {
            if (index == digits.Length)
            {
                int[] temp = new int[digits.Length + 10];
                for (int j = 0; j < digits.Length; j++) temp[j] = digits[j];
                digits = temp;
            }
            digits[index++] = num % 10;// last digit
            num /= 10;//remove last digit
        }

        int largest = 0, second = 0;

        //find thr  largst and secndlargest
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest) { second = largest; largest = digits[i]; }
            else if (digits[i] > second) second = digits[i];
        }

        Console.WriteLine("Largest = " + largest);
        Console.WriteLine("Second Largest = " + second);
    }
}
