using System;

class PalindromeChecker5
{
    //read thr input
    static string ReadInput()
    {
        Console.WriteLine("Enter text:");
        return Console.ReadLine();
    }

    //check trh logic of palindrome 
    static bool IsPalindrome(string text)
    {
        int left=0;
        int right=text.Length-1;

        while(left<right)
        {
            if(text[left]!=text[right]) return false;
            left++;
            right--;
        }
        return true;
    }

    //show thr result
    static void ShowResult(bool result)
    {
        if(result) Console.WriteLine("Palindrome");
        else Console.WriteLine("Not a Palindrome");
    }

    static void Main()
    {
        string input=ReadInput();
        bool check=IsPalindrome(input);
        ShowResult(check);
    }
}
