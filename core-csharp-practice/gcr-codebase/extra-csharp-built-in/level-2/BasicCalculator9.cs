using System;

class BasicCalculator9
{
    static int Add(int a,int b){return a+b;}
    static int Sub(int a,int b){return a-b;}
    static int Mul(int a,int b){return a*b;}
    static int Div(int a,int b){return a/b;}

    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int x=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int y=int.Parse(Console.ReadLine());

        Console.WriteLine("Choose operation:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        int ch=int.Parse(Console.ReadLine());

        if(ch==1) Console.WriteLine("Result: "+Add(x,y));
        else if(ch==2) Console.WriteLine("Result: "+Sub(x,y));
        else if(ch==3) Console.WriteLine("Result: "+Mul(x,y));
        else if(ch==4) Console.WriteLine("Result: "+Div(x,y));
        else Console.WriteLine("Invalid choice");
    }
}
