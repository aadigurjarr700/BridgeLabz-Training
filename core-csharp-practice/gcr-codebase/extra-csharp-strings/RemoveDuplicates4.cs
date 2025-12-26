using System;

class RemoveDuplicates4
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input=Console.ReadLine();//take thr input from usr 

        string result="";
        foreach(char c in input)
        {
            if(!result.Contains(c.ToString())) result+=c;//add if not present
        }

        Console.WriteLine("Modified string: "+result);
    }
}
