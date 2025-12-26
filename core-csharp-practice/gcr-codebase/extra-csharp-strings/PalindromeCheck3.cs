using System;

class PalindromeCheck3
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input=Console.ReadLine();//tajke thr input from user 

        string reversed="";
        for(int i=input.Length-1;i>=0;i--) reversed+=input[i];//reverse  thr letters 

        if(input.Equals(reversed)) Console.WriteLine("Palindrome");
        else Console.WriteLine("Not a Palindrome");
    }
}
