using System;
//Problem 12.	* Zero Subset
//We are given 5 integer numbers. Write a program that 
//finds all subsets of these numbers whose sum is 0. 
//Assume that repeating the same subset several times is not a problem. 

namespace _12.ZeroSubset
{
    class ZeroSubset
    {
        static int[] n = { 3, -3, 2, -2, 8 };
        // array of indexes of numbers used in subset
        static int[] indexes = new int[5];
        static int k; // current combination/subset count

        static void CheckSubset()
        {
            int subsetSum = 0;
            for (int i = 0; i <= k; i++)
            {
                subsetSum += n[indexes[i]];
            }

            if (subsetSum == 0)
            {
                for (int i = 0; i <= k; i++)
                {
                    Console.Write(n[indexes[i]] + 
                        (i == k ? " = 0\n" : " + "));
                }
            }
        }

        static void Combination(int i, int next)
        {
            if (i > k) return;

            for (int j = next; j < n.Length; j++)
            {
                indexes[i] = j;
                if (i == k) CheckSubset();
                Combination(i + 1, j + 1);
            }
        }

        static void Main()
        {
            for (k = 0; k < n.Length; k++)
            {
                Combination(0, 0);
            }
        }
    }
}