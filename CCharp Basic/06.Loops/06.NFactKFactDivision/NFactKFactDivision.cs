using System;
//Problem 6.	Calculate N! / K!
//Write a program that calculates n! / k! for given 
//n and k (1 < k < n < 100). Use only one loop. 

class NFactKFactDivision
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int sum = 1;

        if (k > 1 && n > k && n < 100)
        {
            while (n > k)
            {
                sum *= n;
                n--;
            }
        }

        Console.WriteLine(sum);
    }
}