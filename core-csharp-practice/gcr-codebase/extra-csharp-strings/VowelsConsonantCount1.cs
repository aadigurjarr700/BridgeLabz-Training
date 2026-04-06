using System;

class VowelsConsonantCount1
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input=Console.ReadLine();//take thr input from user 

        int vowels=0;
        int consonants=0;

        foreach(char c in input)
        {
            char ch=Char.ToLower(c);
            if(ch>='a'&&ch<='z') //the only letter 
            {
                if(ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u') vowels++;
                else consonants++;
            }
        }

        Console.WriteLine("Vowels: "+vowels);
        Console.WriteLine("Consonants: "+consonants);
    }
}
