using System;
//Problem 5.	The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers. 


class BiggestOfThree
{
    static void Main()
    {
        int max = int.MinValue;

        for (int i = 0; i < 3; )
        {
            int num = int.Parse(Console.ReadLine());
            if (num > max) max = num;
        }
    }
}