using System;

class SubstringCount6
{
    static void Main()
    {
        Console.WriteLine("Enter main text:");
        string text=Console.ReadLine();//take thr input from user

        Console.WriteLine("Enter substring to search:");
        string sub=Console.ReadLine();//take the subsstrimng input 

        int count=0;
        for(int i=0;i<=text.Length-sub.Length;i++)
        {
            string temp="";
            for(int j=0;j<sub.Length;j++) temp+=text[i+j];//build trh part 
            if(temp.Equals(sub)) count++;//matchthr  found
        }

        Console.WriteLine("Occurrences: "+count);
    }
}
