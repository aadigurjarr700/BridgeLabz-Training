using System;
using System.Collections.Generic;

class WordSplitter11
{
    //get thr string length
    static int GetLength(string text)
    {
        int len=0;
        foreach(char c in text)len++;
        return len;
    }

    //split  thr words
    static List<string> SplitWords(string text)
    {
        List<string> words=new List<string>();
        string word="";
        for(int i=0;i<GetLength(text);i++)
        {
            if(text[i]!=' ')word+=text[i];
            else if(word!="")
            {
                words.Add(word);
                word="";
            }
        }
        if(word!="")words.Add(word);//add thr last word
        return words;
    }

    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input=Console.ReadLine();//take thr input form usr 

        List<string> words=SplitWords(input);
        Console.WriteLine("Word - Length:");
        foreach(string w in words)
        {
            Console.WriteLine(w+" - "+GetLength(w));//show  thr word and length
        }
    }
}
