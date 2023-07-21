using System;

public static class PalindromeNumber9
{
    public static void Main()
    {
        Console.WriteLine(IsPalindrome(101));
        Console.WriteLine(IsPalindrome(1221));
        Console.WriteLine(IsPalindrome(4));
        Console.WriteLine(IsPalindrome(34));
    }

    static bool IsPalindrome(int x)
    {
        string xStr = x.ToString();

        for (int i = 0; i < xStr.Length; i++)
        {
            if (i == xStr.Length - i)
            {
                continue;
            }
            else if (xStr[i] != xStr[xStr.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}