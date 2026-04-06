using System;

namespace PasswordCracker
{
    static class ComplexityUtil
    {
        public static void Show()
        {
            Console.WriteLine("\n--- Complexity Analysis ---");
            Console.WriteLine("k = number of characters");
            Console.WriteLine("n = password length");
            Console.WriteLine("Time Complexity  : O(k^n)");
            Console.WriteLine("Space Complexity : O(n)");
        }
    }
}
