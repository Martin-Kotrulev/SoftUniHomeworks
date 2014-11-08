using System;

class LongestWordInText
{
    static void Main(string[] args)
    {
        string[] input =
            Console.ReadLine().Split(new char[] { ',', '.', '!', '?', ' ' });
        string longest = input[0];
        int bestLen = input[0].Length;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length > bestLen)
            {
                longest = input[i];
                bestLen = input[i].Length;
            }
        }

        Console.WriteLine(longest);
    }
}