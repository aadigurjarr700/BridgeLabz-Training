using System;

class SumNaturalNo12
{
    static void Main()
    {
        int n,sum=0,i=1;//intilaize varible

        Console.WriteLine("Enter number:");
        n=Convert.ToInt32(Console.ReadLine()); //inpt

        if(n>=1) //cherclk naturl no.
        {
            while(i<=n)
            {
                sum+=i; //add
                i++;
            }

            int formula=n*(n+1)/2;//formula

            Console.WriteLine("While Sum:"+sum);
            Console.WriteLine("Formula Sum:"+formula);
            Console.WriteLine("Equal:"+(sum==formula));
        }
        else
        {
            Console.WriteLine("Not a natural number");
        }
    }
}
