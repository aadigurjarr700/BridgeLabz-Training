using System;
using System.IO;

class FileReadingComparison
{
    static void ReadUsingStreamReader(string path)
    {
        // StreamReader reads character by character
        using (StreamReader reader = new StreamReader(path))
        {
            while (reader.ReadLine() != null)
            {
                // Reading each line (slower for large files)
            }
        }
        Console.WriteLine("File read using StreamReader.");
    }

    static void ReadUsingFileStream(string path)
    {
        // FileStream reads raw bytes
        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            byte[] buffer = new byte[4096];
            while (fs.Read(buffer, 0, buffer.Length) > 0)
            {
                // Reading chunks of bytes (faster)
            }
        }
        Console.WriteLine("File read using FileStream.");
    }

    static void Main()
    {
        string filePath = "/Users/adityagurjar/Desktop/BridgeLabz-Training/datastructure-csharp-practice/gcr-codebase/csharp-algorithm-analysis/input.txt";

        ReadUsingStreamReader(filePath);
        ReadUsingFileStream(filePath);
    }
}
