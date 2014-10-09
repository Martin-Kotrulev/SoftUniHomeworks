using System;
//Problem 8.	Prime Number Check
//Write an expression that checks if given positive integer 
//number n (n ≤ 100) is prime (i.e. it is divisible without 
//remainder only to itself and 1). 

class PrimeNumberCheck
{
    static bool IsPrime(int n)
    {
        if (n < 2) return false;

        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;

        return true;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(n));
    }
}