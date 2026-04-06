using System;

class FormatExceptionDemo7
{
    //format thr  error demo
    static void ShowFormatError()
    {
        try
        {
            string value="abc";//thr nonumber
            int num=int.Parse(value);//error line 
            Console.WriteLine(num);
        }
        catch(FormatException e)
        {
            Console.WriteLine("Exception:"+e.GetType().Name);//handleed 
        }
    }

    static void Main()
    {
        ShowFormatError();//call thr method 
    }
}
