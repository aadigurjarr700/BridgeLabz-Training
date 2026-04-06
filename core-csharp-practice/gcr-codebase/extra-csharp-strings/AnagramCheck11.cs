using System;

class AnagramCheck11
{
    static bool AreAnagrams(string s1,string s2)
    {
        if(s1.Length!=s2.Length) return false;//length thr mismatch

        int[] count=new int[256];//count oif ascii 
        foreach(char c in s1) count[c]++;//count s1
        foreach(char c in s2) count[c]--;//subtract s2

        foreach(int x in count) if(x!=0) return false;
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Enter first string:");
        string str1=Console.ReadLine();//take thr input from user 

        Console.WriteLine("Enter second string:");
        string str2=Console.ReadLine();//tak ethe input from user 

        if(AreAnagrams(str1,str2)) Console.WriteLine("Strings are anagrams");
        else Console.WriteLine("Strings are not anagrams");
    }
}
