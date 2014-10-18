using System;
//Problem 1.	Exchange If Greater
//Write an if-statement that takes two integer 
//variables a and b and exchanges their values if 
//the first one is greater than the second one. 
//As a result print the values a and b, separated by a space. 

class ExchangeIfGreater
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int swap;

        if (a > b)
        {
            swap = a;
            a = b;
            b = swap;
        }

        Console.WriteLine("{0} {1}", a, b);
    }
}