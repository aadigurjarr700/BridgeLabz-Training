using System;

class LargestOfThree3
{
    static void Main()
    {
        int number1,number2,number3; //take teh inpts

        Console.WriteLine("Enter three numbers:");
        number1=Convert.ToInt32(Console.ReadLine());
        number2=Convert.ToInt32(Console.ReadLine());
        number3=Convert.ToInt32(Console.ReadLine());

        bool firstLargest=number1>number2 && number1>number3;  //check first no.
        bool secondLargest=number2>number1 && number2>number3; //check second no.
        bool thirdLargest=number3>number1 && number3>number2;  //check third no.

        Console.WriteLine("Is the first number the largest? "+firstLargest);
        Console.WriteLine("Is the second number the largest? "+secondLargest);
        Console.WriteLine("Is the third number the largest? "+thirdLargest);
    }
}
