using System;

class Factorial15
{
    static void Main()
    {
        int n,fact=1;//intialize th varibls

        Console.WriteLine("Enter number:");
        n=Convert.ToInt32(Console.ReadLine());

        if(n>=1)//check the psitive no.
        {
            for(int i=1;i<=n;i++)
            {
                fact*=i;
            }

            Console.WriteLine("Factorial:"+fact);
        }
        else
        {
            Console.WriteLine("Enter positive number");
        }
    }
}
