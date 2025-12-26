using System;

class ReturnCharacters3
{
    //trh char fetch
    static char[] GetChars(string text)
    {
        char[] data=new char[text.Length];
        for(int i=0;i<text.Length;i++)
        {
            data[i]=text[i];//copy thr char 
        }
        return data;//return thr array
    }

    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input=Console.ReadLine();//tajke the input from user 

        char[] custom=GetChars(input);//manual 
        char[] builtin=input.ToCharArray();//built in 

        Console.WriteLine("Custom length:"+custom.Length);
        Console.WriteLine("Built-in length:"+builtin.Length);

        Console.WriteLine("Custom chars:");
        for(int i=0;i<custom.Length;i++)
        {
            Console.Write(custom[i]+" ");
        }

        Console.WriteLine("\nBuilt-in chars:");
        for(int i=0;i<builtin.Length;i++)
        {
            Console.Write(builtin[i]+" ");
        }
    }
}
