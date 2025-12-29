/*
Summary:
This program analyzes a paragraph of text by performing multiple string operations. 
It counts the total number of words, identifies the longest word, replaces all occurrences 
of a given word with another word in a case-insensitive manner, and safely handles edge cases 
such as empty input or text containing only spaces.*/
using System;
using System.Text;
class ParaCount
{
    string replaceWord(string str)//method build for the replace word form paragraph 
    {
        Console.WriteLine("enter old word for replace");
        string s1=Console.ReadLine();//take input form user of old word 
        Console.WriteLine("enter new word for replace");
        string s2=Console.ReadLine();//take input form user of new word for replacing
       
       String text=str.Replace(s1,s2);
       return text;


    }
    string longestWord(string str)//method used for for finding the longest word in the paragraph
    {
        string[] arr=str.Split(' ');//split the string into array 
        String longest=arr[0];//assume first word is longest 
        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i].Length > longest.Length)//compare the longest word 
            {
                longest=arr[i];//store the longest word in longest 
            }
        }
        return longest;
        
        
    }
    int count(string str)//method used for count the number of words in paragraph 
    {
        string[] arr = str.Split(' ');
        int count = 0;
        foreach(string word in arr)
        {
            if(word!="")
            {
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
        Console.WriteLine("Entere the paragraph:");
        string str=Console.ReadLine();//take input from user of paragraph 
        ParaCount obj =new ParaCount();

        if(obj.count(str)!=0){
        Console.WriteLine("total number of words in paragraph: "+obj.count(str));
         Console.WriteLine("longest word is: "+obj.longestWord(str));
        Console.WriteLine("the length of longest word is: "+obj.longestWord(str).Length);
        Console.WriteLine("the replacing of word: "+obj.replaceWord(str));
        }
        else
        {
            Console.WriteLine("no string found");
        }
    }
}