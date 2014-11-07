using System;
//We are given n numbers, e.g. {3, 7, 2, 8, 1, 4, 6, 9}. 
//We split them into triples: sequences of 3 consecutive 
//numbers (except the last sequence that could have 1 or 2 numbers). 
//In our example, the numbers are split into these triples: 
//the first three numbers {3, 7, 2}; the second three numbers 
//{8, 1, 4}; the last two numbers {6, 9}. Write a program 
//that enters n numbers and finds the triple with biggest 
//sum of numbers. In our example this is the last triple: 
//{6, 9}. In case there are several triples with the same 
//biggest sum, print the leftmost of them.

//Input
//The input data should be read from the console. The 
//input data consists of exactly one line holding the 
//input numbers, separated one from another by a space.
//The input data will always be valid and in the format
//described. There is no need to check it explicitly.

//Output
//You have to print at the console the leftmost biggest
//triple as sequence of up to 3 numbers, separated by a space.
//Constraints
//•	The input numbers will be integers in range [-1000 … 1000]. 
//•	The number of the input numbers n will be between 1 and 1000.
//•	Allowed work time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.

class BiggestTriple
{
    static void Main()
    {
        string[] input = Console.ReadLine().Trim().Split(' ');
        int[] nums = new int[input.Length];

        for (int i = 0; i < nums.Length; i++)
            nums[i] = int.Parse(input[i]);

        int max = int.MinValue;
        int bestIndex = 0;
        int bestLen = 0;
        int len = 0;
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            len++;

            if (len == 3 || i == nums.Length - 1)
            {
                if (sum > max)
                {
                    max = sum;
                    bestIndex = (i - len) + 1;
                    bestLen = len;
                }
                len = 0;
                sum = 0;
            }
        }

        //Printing result
        for (int i = bestIndex; i < bestIndex + bestLen; i++)
        {
            Console.Write((i != bestIndex ? " " : "") + nums[i]);
        }
    }
}