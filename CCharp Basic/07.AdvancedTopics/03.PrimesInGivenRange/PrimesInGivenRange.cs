using System;
using System.Collections.Generic;
//Problem 3.	Primes in Given Range
//Write a method that calculates all prime numbers 
//in given range and returns them as list of integers:
//static List<int> FindPrimesInRange(startNum, endNum)
//{
//    …
//}
//Write a method to print a list of integers. Write 
//a program that enters two integer numbers 
//(each at a separate line) and prints all primes
//in their range, separated by a comma.

class PrimesInGivenRange
{
    static bool IsPrime(int n)
    {
        if (n < 2) return false;

        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;

        return true;
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();

        for (int i = startNum; i <= endNum; i++) 
            if (IsPrime(i)) primes.Add(i);

        return primes;
    }

    static void Main()
    {

        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        List<int> primes = FindPrimesInRange(startNum, endNum);

        if (primes.Count == 0)
        { 
            Console.WriteLine("(empty list)");
            return;
        }

        foreach (var prime in primes) Console.WriteLine(prime);
    }
}