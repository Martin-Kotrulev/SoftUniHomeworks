﻿using System;
//Problem 9.	Matrix of Numbers
//Write a program that reads from the console a positive 
//integer number n (1 ≤ n ≤ 20) and prints a matrix 
//like in the examples below. Use two nested loops.
//Examples:
//n	matrix		n	matrix		n	matrix
//2	1 2         3	1 2 3       4	1 2 3 4
//  2 3             2 3 4           2 3 4 5
//                  3 4 5           3 4 5 6
//                                  4 5 6 7		    

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,2}", i + j);
            }
            Console.WriteLine();
        }
    }
}