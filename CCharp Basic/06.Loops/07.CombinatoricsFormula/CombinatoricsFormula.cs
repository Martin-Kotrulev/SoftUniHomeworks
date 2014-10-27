using System;
using System.Numerics;
//Problem 7.	Calculate N! / (K! * (N-K)!)
//In combinatorics, the number of ways to choose k different 
//members out of a group of n different elements (also known
//as the number of combinations) is 
//calculated by the following formula:
// N! / (K! * (N-K)!)
//For example, there are 2598960 ways to withdraw 
//5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates 
//n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops. 

class CombinatoricsFormula
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int c = n - k;
        BigInteger devident = 1;
        BigInteger divisor = 1;

        if (k > 1 && n > k && n < 100)
        {
            while (n > k)
            {
                devident *= n;
                n--;
            }

            while (c > 0)
            {
                divisor *= c;
                c--;
            }
        }

        Console.WriteLine(devident / divisor);
    }
}