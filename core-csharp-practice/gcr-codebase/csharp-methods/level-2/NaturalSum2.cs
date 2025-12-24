using System;

class NaturalSum2
{
    static int RecursiveSum(int n)//methdo to caluclate the sum recursivly
    {
        if(n==0)return 0;
        return n+RecursiveSum(n-1);
    }

    static int FormulaSum(int n)//methdo to caluclate sum using formula
    {
        return n*(n+1)/2;
    }

    static void Main()
    {
        Console.Write("Enter n: ");
        int n=Convert.ToInt32(Console.ReadLine());//take the inpt from usr 

        if(n<=0)return;

        int rSum=RecursiveSum(n);
        int fSum=FormulaSum(n);

        Console.WriteLine("Recursive Sum: "+rSum);
        Console.WriteLine("Formula Sum: "+fSum);

        if(rSum==fSum)
            Console.WriteLine("Both results are correct");
        else
            Console.WriteLine("Results do not match");
    }
}
