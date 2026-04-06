using System;

class ArgumentOutOfRangeDemo6
{
    //substring error demo
    static void ShowArgumentError()
    {
        try
        {
            string text="Programming";//sample thr text
            Console.WriteLine(text.Substring(8,20));//invalid thr range
        }
        catch(ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Exception:"+e.GetType().Name);
        }
    }

    static void Main()
    {
        ShowArgumentError();//call thr methoid 
    }
}
