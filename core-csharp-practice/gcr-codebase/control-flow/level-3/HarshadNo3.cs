using System;

class HarshadNo3
{
    static void Main()
    {
        int number;//take the inpot 
        int temp;
        int sum=0;

        Console.WriteLine("Enter number:");
        number=Convert.ToInt32(Console.ReadLine());
        temp=number;
        while(temp!=0)
        {
            sum=sum+(temp%10);
            temp=temp/10;
        }

        //check the  dvsblty
        if(number%sum==0)
            Console.WriteLine("Harshad Number");
        else
            Console.WriteLine("Not a Harshad Number");
    }
}
