using System;
// SOLUTION CHECKED - 100%;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int roof = n / 2 + 1;
        int left = n / 2;
        int right = left;
        int bottom = n / 2;

        for (int i = 0; i < roof; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == roof - 1) Console.Write('*');
                else
                {
                    if (j == left || j == right) Console.Write('*');
                    else Console.Write('.');
                }
            }
            left--;
            right++;
            Console.WriteLine();
        }

        right = n - n / 4 - 1;
        left = n / 4;

        for (int i = 0; i < bottom; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == left || j == right ||
                    (i == bottom - 1 && j > left && j < right)) Console.Write('*');
                else Console.Write('.');
            }
            Console.WriteLine();
        }
    }
}