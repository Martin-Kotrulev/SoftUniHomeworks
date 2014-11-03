using System;
//Problem 3 – Star
//You will be given an integer N. Your task is to 
//draw a star on the console. The width of the star 
//is (2*N+1). The height of the star is (N*2 - (N/2-1)).
//The top and the middle part height is exactly (N/2).
//The height of the legs is (N/2+1). Check the examples
//below to understand your task better.
//Input
//The input data is read from the console. The number 
//N stays alone at the first line. The input data will
//always be valid and in the format described. There is
//no need to check it explicitly.
//Output
//•	The output data must be printed on the console.
//•	You must print at the console a star of size N 
//following the formulas above and the examples below.

// SOLUTION CHECKED - 100%

class Star
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int heigh = 2 * n - (n / 2 - 1);
        int width = 2 * n + 1;
        int headLeft = n;
        int headRight = n;
        int outLeft = 1;
        int outRight = width - 2;

        for (int i = 0; i < heigh; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if ((i < n / 2 || i > n - 1) && // head
                    (j == headLeft || j == headRight)) Console.Write('*');
                else if ((i == n / 2 || i == heigh - 1) &&
                    (j < headLeft || j > headRight)) Console.Write('*');
                else if ((i > n / 2 && i < heigh) &&  // legs
                  (j == outLeft || j == outRight)) Console.Write('*');
                else Console.Write('.');
            }

            if (i < n / 2 - 1 || i > n - 1) //head/inner legs
            {
                headLeft--;
                headRight++;
            }
            if (i == n / 2)
            {
                headLeft = n;
                headRight = n;
            }
            if (i < n && i > n / 2) // legs
            {
                outRight--;
                outLeft++;
            }
            else if (i >= n)
            {
                outRight++;
                outLeft--;
            }

            Console.WriteLine();
        }
    }
}