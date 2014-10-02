using System;
// sequence splitted in two subsequences
// every subsequnce has equal number of elements
// compare the subsums of the two subsequnces
// sequence of n*2 numbers

// SOLUTION TESTED - 100%
class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstSeqSum = 0;
        int secondSeqSum = 0;

        for (int i = 1; i <= n * 2; i++)
        {
            int current = int.Parse(Console.ReadLine());
            if (i <= n) firstSeqSum += current;
            else secondSeqSum += current;
        }
        if (firstSeqSum == secondSeqSum) Console.WriteLine("Yes, sum={0}", firstSeqSum);
        else Console.WriteLine("No, diff={0}", Math.Abs(firstSeqSum - secondSeqSum));
    }
}