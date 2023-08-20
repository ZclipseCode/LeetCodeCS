using System;

public static class LongestPalindromicSubstring5
{
    public static void Main()
    {
        Console.WriteLine(LongestPalindrome("babad"));
        Console.WriteLine(LongestPalindrome("cbbd"));
    }

    public static string LongestPalindrome(string s)
    {
        string current = "";
        string longest = "";

        for (int i = 0; i < s.Length; i++)
        {
            current = "";

            for (int j = i; j < s.Length; j++)
            {
                current += s[j];

                if (IsPalindrome(current) && current.Length > longest.Length)
                {
                    longest = current;
                }
            }
        }

        return longest;
    }

    public static bool IsPalindrome(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != s[s.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}