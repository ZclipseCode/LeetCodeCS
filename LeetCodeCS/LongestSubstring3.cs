using System;

public static class LongestSubstring3
{
    public static void Main()
    {
        Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
        Console.WriteLine(LengthOfLongestSubstring("bbbbb"));
        Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
        Console.WriteLine(LengthOfLongestSubstring("dvdf"));
    }

    static int LengthOfLongestSubstring(string s)
    {
        string subStr = "";
        string longest = "";

        for (int i = 0; i < s.Length; i++)
        {
            subStr += s[i];

            if (i < s.Length - 1)
            {
                for (int j = 0; j < subStr.Length; j++)
                {
                    if (subStr[j] == s[i + 1])
                    {
                        if (subStr.Length > longest.Length)
                        {
                            longest = subStr;
                        }

                        string temp = subStr;
                        subStr = "";

                        for (int k = j + 1; k < temp.Length; k++)
                        {
                            subStr += temp[k];
                        }

                        break;
                    }
                }
            } 
        }

        if (subStr.Length > longest.Length)
        {
            longest = subStr;
        }

        return longest.Length;
    }
}