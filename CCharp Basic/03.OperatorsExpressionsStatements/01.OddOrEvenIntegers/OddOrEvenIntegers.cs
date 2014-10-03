using System;
//Problem 1.	Odd or Even Integers
//Write an expression that checks if given integer is odd or even

class OddOrEvenIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool check = (n & 1) == 1 ? true : false;
        Console.WriteLine("Odd?\n{0}", check);
    }
}