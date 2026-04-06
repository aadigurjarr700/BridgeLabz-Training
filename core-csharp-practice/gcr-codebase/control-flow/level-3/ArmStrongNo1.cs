using System;

class ArmstrongNumber
{
    static void Main()
    {
        int number;//take the inpot
        int originalNumber;// stor ethe originila number 
        int sum=0;

        Console.WriteLine("Enter number:");
        number=Convert.ToInt32(Console.ReadLine());

        originalNumber=number;
        while(originalNumber!=0)
        {
            int digit=originalNumber%10;//take the last digit 
            sum=sum+(digit*digit*digit);
            originalNumber=originalNumber/10;//remove the last digt
        }

        //chckh oginal numbe to sum
        if(sum==number)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not an Armstrong Number");
    }
}
