using System;

class CreateSubstring2
{
    //buld thr substring manually
    static string MakeSubstring(string text,int start,int end)
    {
        string result="";
        for(int i=start;i<end;i++)
        {
            result+=text[i];//add thr char
        }
        return result;//finale reuslt 
    }

    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input=Console.ReadLine();//take the rinput form user 

        Console.WriteLine("Start index:");
        int s=int.Parse(Console.ReadLine());// take inputr from user of start 

        Console.WriteLine("End index:");
        int e=int.Parse(Console.ReadLine());//take teh inptu from user of end 

        string custom=MakeSubstring(input,s,e);//logic
        string builtin=input.Substring(s,e-s);//built-in

        Console.WriteLine("Custom substring:"+custom);
        Console.WriteLine("Substring method:"+builtin);
    }
}
