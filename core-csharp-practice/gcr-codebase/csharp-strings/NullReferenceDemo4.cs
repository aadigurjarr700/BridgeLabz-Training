using System;

class NullReferenceDemo4
{
    //null thr ccess demo
    static void ShowNullError()
    {
        try
        {
            string text=null;//null thr  value
            Console.WriteLine(text.Length);//error thr  line
        }
        catch(NullReferenceException e)
        {
            Console.WriteLine("Exception:"+e.GetType().Name);
        }
    }

    static void Main()
    {
        ShowNullError();//call thr method 
    }
}
