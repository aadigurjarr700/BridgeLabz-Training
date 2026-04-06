using System;

namespace PasswordCracker
{
    class PasswordMatcher : IPasswordOperation
    {
        private string password;           // encapsulated
        private bool found = false;
        private char[] characters = { 'a', 'b', 'c' };

        public PasswordMatcher(string password)
        {
            this.password = password;
        }

        public void Execute()
        {
            Match("", 0);

            if (!found)
                Console.WriteLine("Password not found");
        }

        private void Match(string attempt, int index)
        {
            if (found) return;

            if (index == password.Length)
            {
                Console.WriteLine("Trying: " + attempt);
                if (attempt == password)
                {
                    Console.WriteLine("Password matched!");
                    found = true;
                }
                return;
            }

            foreach (char c in characters)
            {
                Match(attempt + c, index + 1);
            }
        }
    }
}
