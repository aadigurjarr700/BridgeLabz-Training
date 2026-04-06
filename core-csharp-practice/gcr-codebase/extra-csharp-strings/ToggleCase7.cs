using System;

class ToggleCase7
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input=Console.ReadLine();//take thr input frokm usr 

        string result="";
        foreach(char c in input)
        {
            if(c>='A'&&c<='Z') result+=(char)(c+32);//uppercase to lowercase
            else if(c>='a'&&c<='z') result+=(char)(c-32);//lowercase to uppercase
            else result+=c;//non-letter
        }

        Console.WriteLine("Toggled case: "+result);
    }
}
