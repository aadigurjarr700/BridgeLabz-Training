using System;

class DataTypes
{
    static void Main()
    {
        
        // 1. Integer (int)
        int intNum = 100;
        Console.WriteLine("Integer example: " + intNum);

        // 2. Float
        float floatNum = 12.5f;
        Console.WriteLine("Float example: " + floatNum);

        // 3. Double
        double doubleNum = 123.456;
        Console.WriteLine("Double example: " + doubleNum);

        // 4. Char
        char character = 'A';
        Console.WriteLine("Char example: " + character);

        // 5. Boolean
        bool isTrue = true;
        Console.WriteLine("Boolean example: " + isTrue);

        // 6. String
        string name = "Abhishek";
        Console.WriteLine("String example: " + name);

        Console.WriteLine();
        Console.WriteLine("===== Type Casting Examples =====");

        // 7. Implicit Casting (smaller to larger type)
        int smallInt = 50;
        double largeDouble = smallInt;    // Implicit casting
        Console.WriteLine("Implicit Casting (int to double): " + largeDouble);

        // 8. Explicit Casting (larger to smaller type)
        double bigDouble = 123.45;
        int intFromDouble = (int)bigDouble;  // Explicit casting
        Console.WriteLine("Explicit Casting (double to int): " + intFromDouble);

        // 9. Using Convert class
        string strNumber = "200";
        int numFromString = Convert.ToInt32(strNumber);
        Console.WriteLine("Using Convert.ToInt32: " + numFromString);

        double doubleFromString = Convert.ToDouble("123.45");
        Console.WriteLine("Using Convert.ToDouble: " + doubleFromString);

        // 10. String to char array
        string sample = "Hello";
        char firstChar = sample[0];  // Access first character
        Console.WriteLine("First character of \"" + sample + "\": " + firstChar);


        // 11. Numeric to String
        int num = 999;
        string strFromNum = num.ToString();
        Console.WriteLine("Integer to String: " + strFromNum);

        // 12. Char to Int (ASCII value)
        char ch = 'B';
        int asciiValue = ch;  // Implicitly converts char to int (ASCII)
        Console.WriteLine("ASCII value of '" + ch + "': " + asciiValue);

        Console.WriteLine();
        Console.WriteLine("✅ All data type examples and type casting demonstrated!");
    }
}