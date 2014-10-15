using System;
//Problem 11.	* Numbers in Interval Dividable by Given Number
//Write a program that reads two positive integer numbers and 
//prints how many numbers p exist between them such that the 
//reminder of the division by 5 is 0.

class NumbersInIntervalDividable
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine((b - a) / 5 + 1);
    }
}