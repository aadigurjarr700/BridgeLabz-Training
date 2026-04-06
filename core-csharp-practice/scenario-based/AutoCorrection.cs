/*
Summary:
This program auto-corrects a poorly formatted paragraph.
It removes extra spaces, ensures exactly one space after punctuation,
and capitalizes the first letter of each sentence.
The logic works character-by-character without using built-in
string formatting methods.
*/
using System;
class AutoCorrection{
    static string Format(string str)//method building 
    {
        char[] arr=new char[str.Length*2];//array to store the string 
        int index=0;//index for the result

        bool capital=true;//flag for capital letters 
        bool space=false;//flag for allowed spaces 
        
        for(int i=0;i<str.Length;i++)//loop for traverse the string 
        {
            char ch=str[i];//string into single char 
            switch (ch)
            {
                case ' '://handle the spaces 
                if (space)
                    {
                        arr[index++]=' ';
                        space=false;
                    }
                     break;

                case '.'://handle the punctuation marks 
                case '?':
                case '!':
                arr[index++]=ch;
                arr[index++]=' ';
                capital=true;
                space=false;
                break;


                default://handle the characters 
                    if (capital && ch>='a'&&ch<='z')
                    {
                        ch=(char)(ch-32);
                        capital=false;
                    }
                    else if(capital)
                    {
                        capital=false;
                    }
                    arr[index++]=ch;
                    space = true;
                    break;
            }
        }
            int len=index;//remove trailing spaces
            if(len>0 && arr[len-1]==' ')
            {
                len--;
            }
            char[] finalarr=new char[len];//copy the exact size of the array
            for(int i = 0; i < len; i++)
            {
                finalarr[i]=arr[i];
            }
        
        return new string(finalarr);
    }
    static void Main()
    {
        Console.WriteLine("Enter the paragraph: ");
        string str=Console.ReadLine();//take input of string from user 

        string output=Format(str);//call the method
        Console.WriteLine(output);//display the result

    }
}