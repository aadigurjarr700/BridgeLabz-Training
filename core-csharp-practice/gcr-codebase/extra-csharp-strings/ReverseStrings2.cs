using System;

class ReverseStrings2
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input=Console.ReadLine();//take teh input from user 

        string reversed="";
        for(int i=input.Length-1;i>=0;i--) reversed+=input[i];//reverse thr 

        Console.WriteLine("Reversed: "+reversed);
    }
}
