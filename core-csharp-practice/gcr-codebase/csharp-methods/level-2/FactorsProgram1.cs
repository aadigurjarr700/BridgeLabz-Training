using System;

class FactorsProgram1
{
    static int[] FindFactors(int n)//find the factr=ros and retrurn the array 
    {
        int count=0;
        for(int i=1;i<=n;i++)
            if(n%i==0)count++;

        int[] factors=new int[count];
        int index=0;
        for(int i=1;i<=n;i++)
            if(n%i==0)factors[index++]=i;

        return factors;
    }

    static int FindSum(int[] arr) // merthdo to find teh sum 
    {
        int sum=0;
        foreach(int x in arr)sum+=x;
        return sum;
    }

    static long FindProduct(int[] arr)//methdo to find the product 
    {
        long product=1;
        foreach(int x in arr)product*=x;
        return product;
    }

    static double FindSumOfSquares(int[] arr)//methdo tot find teh sum of sqaure 
    {
        double sum=0;
        foreach(int x in arr)sum+=Math.Pow(x,2);
        return sum;
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int num=Convert.ToInt32(Console.ReadLine());//take the inptu from user 

        int[] factors=FindFactors(num);

        Console.WriteLine("Factors:");
        foreach(int x in factors)Console.Write(x+" ");

        Console.WriteLine("\nSum: "+FindSum(factors));
        Console.WriteLine("Product: "+FindProduct(factors));
        Console.WriteLine("Sum of squares: "+FindSumOfSquares(factors));
    }
}
