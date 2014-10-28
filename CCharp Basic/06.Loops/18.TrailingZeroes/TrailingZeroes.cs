using System;
//Problem 18.	* Trailing Zeroes in N!
//Write a program that calculates with 
//how many zeroes the factorial of a given 
//number n has at its end. Your program 
//should work well for very big numbers, e.g. n=100000. 

class TrailingZeroes
{
    static long GetTrailingZeroes(long n)
    {
        long power = 5;
        long trailingZeroes = 0;

        while (power < n)
        {
            n /= power;
            trailingZeroes += n;
        }

        return trailingZeroes;
    }

    static void Main()
    {
        long n = int.Parse(Console.ReadLine());

        Console.WriteLine(GetTrailingZeroes(n));
    }
}