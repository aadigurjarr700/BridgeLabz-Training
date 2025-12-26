using System;

class LexCompare8
{
    static void Main()
    {
        Console.WriteLine("Enter first string:");
        string s1=Console.ReadLine();//take thr inpur from usr 

        Console.WriteLine("Enter second string:");
        string s2=Console.ReadLine();//taek thr input frommm user 

        int len=Math.Min(s1.Length,s2.Length);
        bool decided=false;

        for(int i=0;i<len;i++)
        {
            if(s1[i]<s2[i])
            {
                Console.WriteLine("\""+s1+"\" comes before \""+s2+"\"");
                decided=true;
                break;
            }
            else if(s1[i]>s2[i])
            {
                Console.WriteLine("\""+s1+"\" comes after \""+s2+"\"");
                decided=true;
                break;
            }
        }

        if(!decided)//first thr  prt same,compare thr  lengths
        {
            if(s1.Length<s2.Length) Console.WriteLine("\""+s1+"\" comes before \""+s2+"\"");
            else if(s1.Length>s2.Length) Console.WriteLine("\""+s1+"\" comes after \""+s2+"\"");
            else Console.WriteLine("Both strings are equal");
        }
    }
}
