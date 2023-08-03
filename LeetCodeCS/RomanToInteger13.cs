using System;

public static class RomanToInteger13
{
    public static void Main()
    {
        Console.WriteLine(RomanToInt("III"));
        Console.WriteLine(RomanToInt("LVIII"));
        Console.WriteLine(RomanToInt("MCMXCIV"));
    }

    static int RomanToInt(string s)
    {
        s = s.ToUpper();

        int total = 0;
        char lastChar = ' ';

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'I')
            {
                total++;
            }
            else if (s[i] == 'V')
            {
                if (lastChar == 'I')
                {
                    total += 3;
                    lastChar = s[i];
                    continue;
                }

                total += 5;
            }
            else if (s[i] == 'X')
            {
                if (lastChar == 'I')
                {
                    total += 8;
                    lastChar = s[i];
                    continue;
                }

                total += 10;
            }
            else if (s[i] == 'L')
            {
                if (lastChar == 'X')
                {
                    total += 30;
                    lastChar = s[i];
                    continue;
                }

                total += 50;
            }
            else if (s[i] == 'C')
            {
                if (lastChar == 'X')
                {
                    total += 80;
                    lastChar = s[i];
                    continue;
                }

                total += 100;
            }
            else if (s[i] == 'D')
            {
                if (lastChar == 'C')
                {
                    total += 300;
                    lastChar = s[i];
                    continue;
                }

                total += 500;
            }
            else if (s[i] == 'M')
            {
                if (lastChar == 'C')
                {
                    total += 800;
                    lastChar = s[i];
                    continue;
                }

                total += 1000;
            }

            lastChar = s[i];
        }

        return total;
    }
}