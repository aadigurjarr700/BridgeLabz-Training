using System;

class IndexOutOfRangeDemo5
{
    //invalid index demo 
    static void ShowIndexError()
    {
        try
        {
            string text="Hello";//sample thr text 
            Console.WriteLine(text[10]);//wromng index 
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine("Exception:"+e.GetType().Name);///
        }
    }

    static void Main()
    {
        ShowIndexError();//call the methgdo 
    }
}
