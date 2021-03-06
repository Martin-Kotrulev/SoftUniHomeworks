﻿using System;
//Problem 5 – Double Downs

//You are given a number N and N integers. Write a program
//to count all couples of bits between every two integers
//(num[0] and num[1], num[1] and num[2], …, num[N-2] and
//num[N-1]). You should count 3 kinds of couples: vertical,
//left-diagonal and right-diagonal like at the example 
//on the right. Every “1” bit can be part of multiple 
//couples. Check the comments in the examples to 
//understand your task better.

//Input
//The input data should be read from the console. 
//•	The number n stays at the first line.
//•	At each of the next n lines n integers are given, 
//each at a separate line. 
//The input data will always be valid and in the format 
//described. There is no need to check it explicitly.

//Output
//The output should be printed on the console. It should 
//consist of exactly 3 lines:
//•	At the first line print the count of the right 
//diagonal couples.
//•	At the second line print the count of the left 
//diagonal couples.
//•	At the third line print the count of the vertical couples.

//Constraints
//•	The number n will be an integer number in the range [2…100].
//•	The n numbers will be integers in the range [0…2 147 483 647].
//•	Allowed working time for your program: 0.25 seconds.
//•	Allowed memory: 16 MB.

// SOLUTION CHECKED - 100%

class DoubleDowns
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int[] n = new int[input];
        int rightD = 0;
        int leftD = 0;
        int vertical = 0;

        for (int i = 0; i < input; i++) 
            n[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < n.Length - 1; i++)
        {
            int current = n[i];
            int next = n[i + 1];

            for (int j = 0; j < 32; j++)
            {
                int mask = 1;

                if ((current & mask) == 1)
                {
                    if ((next & mask) == 1) vertical++;
                    if ((next & (mask << 1)) == 2) leftD++; 
                }
                if ((current & (mask << 1)) == 2 && (next & mask) == 1) rightD++;
                current >>= 1;
                next >>= 1;
            }
        }

        Console.WriteLine("{0}\n{1}\n{2}", rightD, leftD, vertical);
    }
}