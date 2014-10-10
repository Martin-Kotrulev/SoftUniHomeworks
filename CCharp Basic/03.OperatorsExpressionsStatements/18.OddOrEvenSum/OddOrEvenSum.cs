using System;
//Problem 18.	** – Odd / Even Sum
//You are given a number n and 2*n numbers. 
//Write a program to check whether the sum of the odd 
//numbers is equal to the sum of the even n numbers. 
//The first number is considered odd, the next even, 
//the next odd again, etc. Print as result “Yes” or “No”. 
//In case of yes, print also the sum. In case of no, 
//print also the difference between the odd and the even sums.
//SOLUTION CHECKED- 100%

class OddOrEvenSum
{
    static bool IsSumsEqual(int odd, int even)
    {
        return odd == even;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int odd = 0;
        int even = 0;

        for (int i = 1; i <= n * 2; i++)
        {
            int current = int.Parse(Console.ReadLine());
            if ((i & 1) == 1) odd += current;
            else even += current;
        }

        if (IsSumsEqual(odd, even)) Console.WriteLine("Yes, sum={0}", odd);
        else Console.WriteLine("No, diff={0}", Math.Abs(odd - even));
    }
}