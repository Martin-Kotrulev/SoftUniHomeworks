using System;
// SOLUTION CHECKED - 100%

class Pairs
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int diff = 0;
        int[] pairs = new int[input.Length / 2];

        for (int i = 0, j = 0; i <= input.Length - 2; i += 2, j++)
        {
            pairs[j] = int.Parse(input[i]) + 
                int.Parse(input[i + 1]);
        }

        for (int i = 0; i < pairs.Length - 1; i++)
        {
            if (pairs[i] == pairs[i + 1]) continue;
            else
            {
                int currentDiff = Math.Abs(pairs[i] - pairs[i + 1]);
                if (diff < currentDiff) diff = currentDiff; 
            }
        }

        if (diff == 0) Console.WriteLine("Yes, value={0}", pairs[0]);
        else Console.WriteLine("No, maxdiff={0}", diff);
    }
}