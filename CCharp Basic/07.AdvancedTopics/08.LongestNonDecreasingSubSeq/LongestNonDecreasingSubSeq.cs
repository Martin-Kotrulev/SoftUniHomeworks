using System;
using System.Collections.Generic;
// TODO
class LongestNonDecreasingSubSeq
{
    static int[] sequnce = { 11, 12, 13, 3, 14, 4, 15, 5, 
                               6, 7, 8, 7, 16, 9, 8 };

    static void Main(string[] args)
    {
        List<int> maxSub = new List<int>();
        List<int> swap = new List<int>();

        for (int i = 0; i < sequnce.Length; i++)
        {
            int current = sequnce[i];
            swap.Add(current);

            
        }

        foreach (var item in maxSub)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
