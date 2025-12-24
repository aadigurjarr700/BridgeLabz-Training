using System;

class NoCheckProgram9{
    static bool IsPositive(int n)//echkc the number is negative aur positive
    {
        return n>=0;
    }
    static string IsEven(int n)//check number is even aur odd 
    {
        return n%2==0 ? "Even" : "Odd";
    }
    static int Compare(int n1,int n2)//compare teh numebrs 
    {
        if(n1>n2)return 1;
        if(n1==n2)return 0;
        return -1;
    }

    static void Main()
    {
        int[] numbers=new int[5];

        for(int i=0;i<5;i++)//take teh  input of five numebrs 
        {
            Console.Write($"Enter number {i+1}: ");
            numbers[i]=Convert.ToInt32(Console.ReadLine());
        }
        for(int i=0;i<5;i++)//cehck teh each numebr 
        {
            if(IsPositive(numbers[i]))
                Console.WriteLine($"{numbers[i]} is Positive and {IsEven(numbers[i])}");
            else
                Console.WriteLine($"{numbers[i]} is Negative");
        }
        //cpmpare first and last number 
        int result=Compare(numbers[0],numbers[4]);
        if(result==1)
            Console.WriteLine("First element is greater than last element");
        else if(result==-1)
            Console.WriteLine("First element is less than last element");
        else
            Console.WriteLine("First and last elements are equal");
    }
}
