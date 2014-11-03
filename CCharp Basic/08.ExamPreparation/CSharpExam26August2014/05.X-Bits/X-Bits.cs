using System;
//Problem 5 – X-Bits
//You are given 8 integer numbers. Write a program to 
//count all X-bits. X-bits are groups of 9 bits 
//(3 rows x 3 columns) forming the letter "X". Your 
//task is to count all X-bits and print their count 
//on the console. Valid X-bits consist of 3 numbers 
//where their corresponding bit indexes are exactly 
//{"101", "010", "101"}. All other combinations like: 
//{"111", "010", "101"} or {"111", "111", "111"} are invalid.
//All valid X-bits can be part of multiple X-bits (with overlapping).
//Check the example on the right to understand your task better.
//Input
//The input data should be read from the console. 
//•	On the first 8 lines, you will be given 8 integers.
//The input data will always be valid and in the format described. 
//There is no need to check it explicitly.
//Output
//The output should be printed on the console. It should 
//consist of exactly 1 line:
//•	At the first line print the count of the X-bits.

// SOLUTION CHECKED - 100%

class XBits
{
    static void Main()
    {
        long[] n = new long[8];
        int xCtr = 0;

        for (int i = 0; i < n.Length; i++)
        {
            n[i] = long.Parse(Console.ReadLine());
        }

        for (int n1 = 0; n1 < n.Length - 2; n1++)
        {
            int n2 = n1 + 1;
            int n3 = n1 + 2;

            for (int bit = 0; bit < 32; bit++)
            {
                if (((n[n1] >> bit) & 7) == 5 &&
                    ((n[n2] >> bit) & 7) == 2 &&
                    ((n[n3] >> bit) & 7) == 5)
                {
                    xCtr++;
                }
            }
        }
        Console.WriteLine(xCtr);
    }
}