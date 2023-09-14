using System;
using System.Collections.Generic;

public static class ReverseInteger7
{
    public static void Main()
    {
        Console.WriteLine(Reverse(123));
        Console.WriteLine(Reverse(-123));
        Console.WriteLine(Reverse(120));
    }

    public static int Reverse(int x)
    {
        string xStr = x.ToString();
        bool isNegative = false;

        if (x < 0)
        {
            string temp = xStr;
            xStr = "";
            isNegative = true;

            for (int i = 1; i < temp.Length; i++)
            {
                xStr += temp[i];
            }
        }

        List<char> charList = new List<char>();

        for (int i = 0; i < xStr.Length; i++)
        {
            charList.Add(xStr[i]);
        }
        charList.Reverse();

        string reverseStr = "";

        if (isNegative)
        {
            reverseStr = "-";
        }
        for (int i = 0; i < charList.Count; i++)
        {
            reverseStr += charList[i];
        }

        if (Int32.TryParse(reverseStr, out int reverse))
        {
            return reverse;
        }

        return 0;
    }
}