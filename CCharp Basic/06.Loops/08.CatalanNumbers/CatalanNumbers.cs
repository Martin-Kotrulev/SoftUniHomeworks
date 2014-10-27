using System;
using System.Numerics;
//Problem 8.	Catalan Numbers
//In combinatorics, the Catalan numbers are calculated by the following formula:
//  (2n)!/(n + 1)!n!
//Write a program to calculate the nth Catalan number by given n (1 < n < 100). 

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dN = 2 * n;
        BigInteger devident = 1;
        BigInteger devisor = 1;

        if (n > 1 && n < 100)
        {
            while (dN > n + 1)
            {
                devident *= dN;
                dN--;
            }

            while (n > 0)
            {
                devisor *= n;
                n--;
            }
        }

        Console.WriteLine(devident / devisor);
    }
}