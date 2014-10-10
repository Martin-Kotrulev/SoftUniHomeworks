using System;
// sequence of 'n' bytes
// step integer 
// every byte is a sequence of 8 bits
// set to one bits on position 1, 1+step, 1+2*step... 
// SOLUTION TESTED - 100%
class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int currentBit = 0; // indexing current 
        // bit in the whole sequence

        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            for (int bitPos = 7; bitPos >= 0; bitPos--)
            {
                if (step == 1 && currentBit > 0 || currentBit % step == 1)
                    currentNum |= (1 << bitPos);                
                currentBit++;
            }
            Console.WriteLine(currentNum);
        }
    }
}