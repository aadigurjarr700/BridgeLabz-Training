using System;

class SumUntilNegativ11
{
    static void Main(string[] args)
    {
        double total = 0;

        while(true)
        {
            Console.WriteLine("Enter a number:");
            double number=double.Parse(Console.ReadLine());

            if(number<=0)//check condn
                break;

            total+=number;
        }

        Console.WriteLine("Total sum is ="+total);
    }
}