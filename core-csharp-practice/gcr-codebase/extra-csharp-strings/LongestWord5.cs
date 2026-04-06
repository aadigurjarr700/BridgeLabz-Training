using System;
using System.Collections.Generic;

class LongestWord5
{
    static void Main()
    {
        Console.WriteLine("Enter sentence:");
        string sentence=Console.ReadLine();//take thr input form usr 

        string word="";
        List<string> words=new List<string>();

        for(int i=0;i<sentence.Length;i++)
        {
            if(sentence[i]!=' ') word+=sentence[i];//build treh words 
            else if(word!="")
            {
                words.Add(word);
                word="";
            }
        }
        if(word!="") words.Add(word);//add trh last word

        string longest="";
        foreach(string w in words)
        {
            if(w.Length>longest.Length) longest=w;//uupdate thr  longest
        }

        Console.WriteLine("Longest word: "+longest);
    }
}
