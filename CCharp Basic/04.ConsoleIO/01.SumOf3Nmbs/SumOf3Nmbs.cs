using System;
//Problem 1.    Sum Of 3 Numbers
//Write a program that reads 3 real numbers 
//from the console and prints their sum. 

class SumOf3Nmbs
{
    static void Main()
    {
        int sum = 0;

        for (int i = 0; i < 3; i++)
        {
            sum += int.Parse(Console.ReadLine());
        }

        Console.WriteLine(sum);
    }
}