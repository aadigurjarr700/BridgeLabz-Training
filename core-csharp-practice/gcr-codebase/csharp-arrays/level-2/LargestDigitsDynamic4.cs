using System;

class LargestDigitsDynamic4
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int original = num;

        int maxDigit = 10;//intial arr size
        int index = 0; 
        int[] digits = new int[maxDigit];

        // str thr  digits in array
        while (num != 0)
        {
            if (index == digits.Length)
            {
                maxDigit += 10; 
                int[] temp = new int[maxDigit];
                for (int j = 0; j < digits.Length; j++) temp[j] = digits[j];
                digits = temp;
            }

            digits[index++] = num % 10;//store last digit
            num /= 10;//remove last digit
        }

        //find thr largest and second largest
        int largest = 0, secondLargest = 0;
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest) 
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine("Largest digit = " + largest);
        Console.WriteLine("Second largest digit = " + secondLargest);
    }
}
