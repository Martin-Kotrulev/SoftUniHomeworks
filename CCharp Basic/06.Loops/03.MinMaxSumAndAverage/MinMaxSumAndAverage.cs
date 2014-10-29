using System;
//Problem 3.	Min, Max, Sum and Average of N Numbers
//Write a program that reads from the console a sequence of n 
//integer numbers and returns the minimal, the maximal number, 
//the sum and the average of all numbers (displayed with 2 
//digits after the decimal point). The input starts by the 
//number n (alone in a line) followed by n lines, each holding
//an integer number. The output is like in the examples below. 

class MinMaxSumAndAverage
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int min = Int32.MinValue;
        int max = Int32.MinValue;
        double avg;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            sum += num;

            if (num > max) max = num;
            if (i == 0 || min > num) min = num;
        }

        avg = (double)sum / n;

        Console.WriteLine("min: {0}\nmax: {1}\nsum: {2}\navg: {3:F2}",
            min, max, sum, avg);
    }
}