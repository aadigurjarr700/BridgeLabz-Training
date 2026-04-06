using System;

class RemoveChar10
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input=Console.ReadLine();//take thr input form user 

        Console.WriteLine("Enter character to remove:");
        char ch=Console.ReadLine()[0];//character 

        string result="";
        foreach(char c in input)
        {
            if(c!=ch) result+=c;//keep if thr not target
        }

        Console.WriteLine("Modified String: "+result);
    }
}
