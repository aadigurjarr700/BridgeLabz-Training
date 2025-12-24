using System;

class SumOfNaturalNo7
{
    static int FindSum(int n)//method to calculate sum
    {
        int sum=0;
        for(int i=1;i<=n;i++)
            sum+=i;
        return sum;
    }

    static void Main()
    {
        Console.Write("Enter value of n: ");
        int n=Convert.ToInt32(Console.ReadLine());//take the input from user 

        int result=FindSum(n);//call the method
        Console.WriteLine("Sum of first "+n+" natural numbers is "+result);
    }
}
