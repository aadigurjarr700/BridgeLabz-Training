using System;
using System.IO;
using System.Text;

class ByteToCharacterDemo
{
    static void Main()
    {
        string filePath="/Users/adityagurjar/Desktop/BridgeLabz-Training/datastructure-csharp-practice/gcr-codebase/csharp-stringbuilder/sample.txt";

        try
        {
            // StreamReader converts byte stream into character stream
            using(StreamReader reader=new StreamReader(filePath,Encoding.UTF8))
            {
                int ch;
                while((ch=reader.Read())!=-1)
                {
                    Console.Write((char)ch);
                }
            }
        }
        catch(Exception e)
        {
            Console.WriteLine("Error: "+e.Message);
        }
    }
}
