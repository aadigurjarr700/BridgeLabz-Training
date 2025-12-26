using System;

class MostFrequentChar9
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input=Console.ReadLine();//take thr input from user 

        int maxCount=0;
        char frequent=' ';

        for(int i=0;i<input.Length;i++)
        {
            int count=0;
            for(int j=0;j<input.Length;j++)
            {
                if(input[i]==input[j]) count++;//countthr  occurrences
            }
            if(count>maxCount)
            {
                maxCount=count;
                frequent=input[i];//update trh most frequent
            }
        }

        Console.WriteLine("Most Frequent Character: '"+frequent+"'");
    }
}
