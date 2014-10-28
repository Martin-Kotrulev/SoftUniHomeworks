using System;
//Problem 19.	** Spiral Matrix
//Write a program that reads from the console a 
//positive integer number n (1 ≤ n ≤ 20) and prints
//a matrix holding the numbers from 1 to n*n in
//the form of square spiral like in the example below
//n	    matrix
//4	    1  2  3  4
//      12 13 14 5
//      11 16 15 6
//      10 9  8  7

class SpiralMatrix
{
    static void PrintMatrix(int[,] mtrx)
    {
        for (int row = 0; row < mtrx.GetLength(0); row++)
        {
            for (int col = 0; col < mtrx.GetLength(1); col++)
                Console.Write("{0, -4}", mtrx[row, col]);
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] spiral = new int[n, n];

        //matrix coordinates
        int mX = 0;
        int mY = 0;

        // current number for printing
        int num = 1;

        // current round of the spiral
        byte round = 0;

        // spiral build;
        while (round < n)
        {
            // building right:
            for (int i = 0 + round; i < spiral.GetLength(1); i++)
            {
                mX = i;
                if (spiral[mY, i] == 0)
                {
                    spiral[mY, i] = num;
                    num++;
                }
                else
                {
                    mX--;
                    break;
                }
            }

            // building down:
            for (int i = mY + 1; i < spiral.GetLength(0); i++)
            {
                mY = i;
                if (spiral[i, mX] == 0)
                {
                    spiral[i, mX] = num;
                    num++;
                }
                else
                {
                    mY--;
                    break;
                }
            }

            // building left:
            for (int i = mX - 1; i >= 0; i--)
            {
                mX = i;
                if (spiral[mY, i] == 0)
                {
                    spiral[mY, i] = num;
                    num++;
                }
                else
                {
                    mX++;
                    break;
                }
            }

            // building up:
            for (int i = mY - 1; i >= 0; i--)
            {
                mY = i;
                if (spiral[mY, mX] == 0)
                {
                    spiral[mY, mX] = num;
                    num++;
                }
                else
                {
                    mY++;
                    break;
                }
            }
            round++;
        }

        PrintMatrix(spiral);
    }
}