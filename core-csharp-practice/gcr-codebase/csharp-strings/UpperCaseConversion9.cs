using System;

class UpperCaseConversion9
{
    //uppercase convert
    static string ToUpperManual(string text)
    {
        char[] arr=text.ToCharArray();//temp thr array
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]>='a'&&arr[i]<='z')
            {
                arr[i]=(char)(arr[i]-32);//logic fo asciii 
            }
        }
        return new string(arr);//final text
    }

    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input=Console.ReadLine();//take thr input form user 

        string custom=ToUpperManual(input);//manual result
        string builtin=input.ToUpper();//built-in

        Console.WriteLine("Manual:"+custom);
        Console.WriteLine("ToUpper:"+builtin);
    }
}
