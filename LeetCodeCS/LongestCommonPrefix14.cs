using System;

public static class LongestCommonPrefix14
{
    public static void Main()
    {
        string[] fl = { "flower", "flow", "flight" };
        string[] none = { "dog", "racecar", "car" };

        Console.WriteLine(LongestCommonPrefix(fl));
        Console.WriteLine(LongestCommonPrefix(none));
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        int shortestIndex = 0;
        string prefix = "";

        for (int i = 1; i < strs.Length; i++)
        {
            if (strs[shortestIndex].Length > strs[i].Length)
            {
                shortestIndex = i;
            }
        }

        if (strs[shortestIndex].Length > 0)
        {
            for (int i = 0; i < strs[shortestIndex].Length; i++)
            {
                prefix += strs[shortestIndex][i];

                for (int j = 0; j < strs.Length; j++)
                {
                    if (prefix[i] == strs[j][i])
                    {
                        continue;
                    }

                    prefix = prefix.Remove(prefix.Length - 1);
                    return prefix;
                }
            }
        }

        return prefix;
    }
}