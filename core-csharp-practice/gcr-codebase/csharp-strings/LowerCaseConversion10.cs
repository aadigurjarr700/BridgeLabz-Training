using System;

class LowerCaseConversion10
{
    //lowercase convert
    static string ToLowerManual(string text)
    {
        char[] arr=text.ToCharArray();//temp thr array
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]>='A'&&arr[i]<='Z')
            {
                arr[i]=(char)(arr[i]+32);//logioc ascii 
            }
        }
        return new string(arr);//final text
    }

    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input=Console.ReadLine();//take thr input from usr 

        string custom=ToLowerManual(input);//result
        string builtin=input.ToLower();//built in

        Console.WriteLine("Manual:"+custom);
        Console.WriteLine("ToLower:"+builtin);
    }
}
