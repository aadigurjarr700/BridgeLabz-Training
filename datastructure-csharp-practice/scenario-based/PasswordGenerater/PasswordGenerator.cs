using System;

namespace PasswordCracker
{
    class PasswordGenerator : IPasswordOperation
    {
        private int length;                 // encapsulated data
        private char[] characters = { 'a', 'b', 'c' };

        public PasswordGenerator(int length)
        {
            this.length = length;
        }

        public void Execute()
        {
            Generate("", 0);
        }

        private void Generate(string current, int index)
        {
            if (index == length)
            {
                Console.WriteLine(current);
                return;
            }

            foreach (char c in characters)
            {
                Generate(current + c, index + 1);
            }
        }
    }
}
