using System;

class ReplaceWord12
{
    static string Replace(string sentence,string oldWord,string newWord)
    {
        string result="";
        int i=0;
        while(i<sentence.Length)
        {
            if(i+oldWord.Length<=sentence.Length&&sentence.Substring(i,oldWord.Length)==oldWord)
            {
                result+=newWord;//replace
                i+=oldWord.Length;
            }
            else
            {
                result+=sentence[i];//keep thr char
                i++;
            }
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter sentence:");
        string sentence=Console.ReadLine();//tak ethr input from input

        Console.WriteLine("Enter word to replace:");
        string oldWord=Console.ReadLine();// the old word 

        Console.WriteLine("Enter new word:");
        string newWord=Console.ReadLine();//teh new word 

        string modified=Replace(sentence,oldWord,newWord);
        Console.WriteLine("Modified sentence: "+modified);
    }
}
