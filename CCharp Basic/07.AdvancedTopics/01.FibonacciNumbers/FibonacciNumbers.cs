using System;
using System.Numerics;
//Problem 1.	Fibonacci Numbers
//Define a method Fib(n) that calculates 
//the nth Fibonacci number. 

class FibonacciNumbers
{
    static BigInteger[] fibonacci;

    static BigInteger IterativeFib(int n)
    {
        BigInteger first = 1;
        BigInteger second = 1;
        BigInteger next = 1;

        for (int i = 2; i <= n; i++)
        {
            next = first + second;
            first = second;
            second = next;
        }

        return next;
    }

    static BigInteger RecursiveFib(int n)
    {
        if (fibonacci[n] == 0)
        {
            fibonacci[n] = RecursiveFib(n - 1) + RecursiveFib(n - 2);
        }

        return fibonacci[n];
    }

    static void Main()
    {
        int n = 100;
        
        fibonacci = new BigInteger[n + 2];
        fibonacci[0] = 1;
        fibonacci[1] = 1;

        Console.WriteLine(RecursiveFib(n));
        Console.WriteLine(IterativeFib(n));
    }
}