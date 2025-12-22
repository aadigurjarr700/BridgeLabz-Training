using System;

class FizzBuzzF2
{
    static void Main()
    {
        int number;// tahke the inpt

        Console.WriteLine("Enter number:");
        number=Convert.ToInt32(Console.ReadLine()); 

        if(number>0)//chekc number is psitvie or not 
        {
            for(int i=1;i<=number;i++) 
            {
                if(i%3==0&&i%5==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i%3==0)//multipli  of 3
                {
                    Console.WriteLine("Fizz");
                }
                else if(i%5==0)//multipli of 5
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Enter positive number");
        }
    }
}
