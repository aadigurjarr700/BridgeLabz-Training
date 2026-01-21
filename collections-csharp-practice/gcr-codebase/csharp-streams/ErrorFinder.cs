using System;
using System.IO;

class ErrorFinder
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("/Users/adityagurjar/Desktop/BridgeLabz-Training/collections-csharp-practice/gcr-codebase/csharp-streams/TestImage.webp"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.ToLower().Contains("error"))
                    Console.WriteLine(line);
            }
        }
    }
}
