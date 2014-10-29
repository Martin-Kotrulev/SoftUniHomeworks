using System;
//Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
//Write a program that, for a given two integer numbers n and x, 
//calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
//Use only one loop. Print the result with 5 digits after the decimal point.

class CalculateSumGivenNAndX
{
    static long Fact(int i)
    {
        if (i <= 1) return 1;

        return i * Fact(i - 1);
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            sum += (double)Fact(i) / Math.Pow(x, i);
        }

        Console.WriteLine("{0:F5}", sum);
    }
}