using System;

class Factorial14
{
    static void Main()
    {
        int n,fact=1,i=1;//intialize th varible

        Console.WriteLine("Enter number:");
        n=Convert.ToInt32(Console.ReadLine());

        if(n>=1)//check no. is psitive
        {
            while(i<=n) 
            {
                fact*=i;
                i++;
            }

            Console.WriteLine("Factorial:"+fact);
        }
        else
        {
            Console.WriteLine("Enter positive number");
        }
    }
}
