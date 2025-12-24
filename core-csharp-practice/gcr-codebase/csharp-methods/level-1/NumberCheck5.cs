using System;

class NumberCheck5{
    static int CheckNumber(int n)//method to cehck the number 
    {
        if(n>0)return 1;
        if(n<0)return -1;
        return 0;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num=Convert.ToInt32(Console.ReadLine());//take input from user 

        int result=CheckNumber(num);//cal the method 

        if(result==1)
            Console.WriteLine("Number is Positive");
        else if(result==-1)
            Console.WriteLine("Number is Negative");
        else
            Console.WriteLine("Number is Zero");
    }
}
