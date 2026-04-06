using System;

class CompareStrings1
{
    //string compare
    static bool CompareUsingIndex(string a,string b)
    {
        if(a.Length!=b.Length)return false;//length check
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]!=b[i])return false;//if char mismatch
        }
        return true;//all match
    }

    static void Main()
    {
        Console.WriteLine("Enter first string:");
        string s1=Console.ReadLine();//take thr input from user 

        Console.WriteLine("Enter second string:");
        string s2=Console.ReadLine();//tak ethe input from user 

        bool customResult=CompareUsingIndex(s1,s2);//logic 
        bool builtinResult=s1.Equals(s2);//builtimn result

        Console.WriteLine("Custom compare:"+customResult);
        Console.WriteLine("Equals method:"+builtinResult);
    }
}
