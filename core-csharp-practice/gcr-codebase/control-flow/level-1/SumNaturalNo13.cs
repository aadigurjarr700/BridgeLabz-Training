using System;

class SumNaturalNo13
{
    static void Main()
    {
        int n,sum=0; //intitlaizez varible

        Console.WriteLine("Enter number:");
        n=Convert.ToInt32(Console.ReadLine()); 

        if(n>=1) //check naturla no.
        {
            for(int i=1;i<=n;i++)
            {
                sum+=i;
            }

            int formula=n*(n+1)/2;

            Console.WriteLine("For Sum:"+sum);
            Console.WriteLine("Formula Sum:"+formula);
            Console.WriteLine("Equal:"+(sum==formula));
        }
        else
        {
            Console.WriteLine("Not a natural number");
        }
    }
}
