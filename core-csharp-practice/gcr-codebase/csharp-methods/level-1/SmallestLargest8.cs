using System;

class SmallestLargest8
{
    public static int[] FindSmallestAndLargest(int number1,int number2,int number3)//method to find smallest and largest
    {
        int smallest=number1;
        int largest=number1;

        if(number2<smallest)smallest=number2;
        if(number3<smallest)smallest=number3;

        if(number2>largest)largest=number2;
        if(number3>largest)largest=number3;

        return new int[]{smallest,largest};
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int n1=Convert.ToInt32(Console.ReadLine());//tak r the input from user 

        Console.Write("Enter second number: ");
        int n2=Convert.ToInt32(Console.ReadLine());//take teh input form user 

        Console.Write("Enter third number: ");
        int n3=Convert.ToInt32(Console.ReadLine());//take the input from usr 

        int[] result=FindSmallestAndLargest(n1,n2,n3);//call thr methdo 

        Console.WriteLine("Smallest: "+result[0]);
        Console.WriteLine("Largest: "+result[1]);
    }
}
