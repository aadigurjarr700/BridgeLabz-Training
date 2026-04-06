using System;

class FirstIsSmallest2
{
    static void Main()
    {
        int number1,number2,number3; //tak the inputs 

        Console.WriteLine("Enter three numbers:");
        number1=Convert.ToInt32(Console.ReadLine());
        number2=Convert.ToInt32(Console.ReadLine());
        number3=Convert.ToInt32(Console.ReadLine());

        bool isSmallest=number1<number2 && number1<number3; 

        Console.WriteLine("Is the first number the smallest? "+isSmallest);
    }
}
