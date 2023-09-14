using System;
using System.Collections.Generic;
using System.Linq;

public static class ZigzagConversion6
{
    public static void Main()
    {
        Console.WriteLine(Convert("PAYPALISHIRING", 4));
    }

    public static string Convert(string s, int numRows)
    {
        List<string> rows = Enumerable.Repeat("", numRows).ToList();
        int currentRow = 0;
        string zigzag = "";

        for (int i = 0; i < s.Length; i++)
        {
            rows[currentRow] += s[i];

            if (currentRow + 1 <= numRows - 1)
            {
                currentRow++;
            }
            else
            {
                currentRow = 0;
            }
        }

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < rows[i].Length; j++)
            {
                zigzag += rows[i][j];
            }
        }

        return zigzag;
    }
}