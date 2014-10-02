using System;
// given sequence of bytes n exp: if we have 3 zeros 
// the sequence will look like this: 00000000 00000000 00000000
// step s - the number of position to invert 
// and also the number of invert operations:
// if s=5 we invert on position - 1, 6, 11, 16 and 21

// SOLUTION TESTED 100%
class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        int seqIndexer = 0; // for indexing the current bit

        for (int i = 0; i < n; i++)
        {
            int current = int.Parse(Console.ReadLine());
            // for every sequence counting from left to right [0 - 7 right to left]
            for (int bitPos = 7; bitPos >= 0; bitPos--)
            {
                seqIndexer++;
                // starting position is 1 and then checking for the correct steps
                if (s == 1 || seqIndexer % s == 1) current ^= (1 << bitPos);
            }
            Console.WriteLine(current);
        }
    }
}