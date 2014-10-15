using System;
//Problem 10.	Fibonacci Numbers
//Write a program that reads a number n and prints 
//on the console the first n members of the Fibonacci 
//sequence (at a single line, separated by spaces) : 
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
//Note that you may need to learn how to use loops. 

class FibonacciNmbs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double a = 0, b = 1;

        while (n-- != 0)
        {
            Console.WriteLine(a);

            b = a + b;
            a = b - a;
        }
    }
}