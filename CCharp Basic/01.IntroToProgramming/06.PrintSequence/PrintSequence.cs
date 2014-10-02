using System;
/// <summary>
/// Problem 7:
/// Write a program that prints the first 10 members of the sequence:
/// 2, -3, 4, -5, 6, -7, ...
/// </summary>
class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i++)
        {
            // determine the odd numbers using '&' operator
            Console.Write(i % 2 == 0 ? "{0}, " : "-{0}, ", i);
        }
    }
}

