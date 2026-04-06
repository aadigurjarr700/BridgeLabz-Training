using System;

class AddTwoNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());//take input from user 

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());//take input from user 

        int sum = num1 + num2;//sum of the numbers 

        Console.WriteLine("Sum = " + sum);//output
        
    }
}
