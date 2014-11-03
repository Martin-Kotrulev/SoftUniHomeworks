using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 4 – Winning Numbers
//We are given a string S consisting of capital and 
//non-capital letters. Every letter has a value equal
//to its position in the English alphabet (a=1, b=2, …, z=26). 
//First you have to calculate the sum of all letters 
//letSum. Then, find all 6-digits numbers in range 
//[000 000 … 999 999] called winning numbers for which
//the following is true: the product of the first three
//digits is equal to the product of the second three 
//digits, and both of those are equal to letSum. Your 
//task is to print on the console all winning numbers.
//Input
//The input data should be read from the console. 
//It consists of 1 line:
//•	On the first line you will be given a string S 
//which will only consist of lower and capital case 
//letters.
//The input data will always be valid and in the format 
//described. There is no need to check it explicitly.
//Output
//The output should be printed on the console as a sequence 
//of winning numbers in format abc-def in ascending order. 
//Each winning number should stay alone on a separate line. 
//In case there are no winning numbers, print “No”.

// SOLUTION CHECKED - 100%

class WinningNumbers
{
    static int FindProductOfDigits(int n)
    {
        int product = n % 10;

        while (n != 0)
        {
            n /= 10;
            if (n != 0) product *= n % 10;
        }

        return product;
    }

    static int MagicSum(string s)
    {
        int magicSum = 0;
        s = s.ToLower();

        for (int i = 0; i < s.Length; i++)
        {
            magicSum += (s[i] - 'a') + 1;
        }

        return magicSum;
    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int letSum = MagicSum(input);
        int winningCtr = 0;

        for (int i = 111; i <= 999; i++)
        {
            for (int j = 111; j < 999; j++)
            {
                if (i % 10 != 0 && j % 10 != 0)
                {
                    int left = FindProductOfDigits(i);
                    int right = FindProductOfDigits(j);

                    if (left == right && left == letSum)
                    {
                        Console.WriteLine("{0}-{1}", i, j);
                        winningCtr++;
                    }
                }
            }
        }
        if (winningCtr == 0) Console.WriteLine("No");
    }
}