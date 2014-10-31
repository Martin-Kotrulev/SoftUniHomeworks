using System;
//Problem 2.	Prime Checker
//Write a Boolean method IsPrime(n) that 
//check whether a given integer number n is prime. 

class PrimeChecker
{
    static bool IsPrime(long n)
    {
        if (n < 2) return false;

        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;

        return true;
    }

    static void Main()
    {
        long n = 23;

        Console.WriteLine(IsPrime(n));
    }
}