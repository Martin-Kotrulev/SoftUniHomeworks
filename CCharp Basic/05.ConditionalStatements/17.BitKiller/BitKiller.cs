using System;
//Problem 17.	** – Bit Killer
//You are given a sequence of bytes. Consider each byte as 
//sequence of exactly 8 bits.  You are given also a number step.
//Write a program to remove (kill) all the bits at positions:
//1, 1 + step, 1 + 2*step, ... Print the output as a sequence 
//of bytes. In case the last byte have less than 8 bits, add 
//trailing zeroes at its right end. Bits in each byte are 
//counted from the leftmost to the rightmost. 
//Bits are numbered starting from 0.

// SOLUTION CHECKED - 100%

class BitKiller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        int bitCtr = 0;
        int keeper = 0;

        for (int i = 0; i < n; i++)
        {
            int current = int.Parse(Console.ReadLine());

            for (int bit = 7; bit >= 0; bit--)
            {
                if (!((step == 1 && index > 0) || (index % step == 1)))
                {
                    int currentBit = (current >> bit) & 1;
                    keeper <<= 1;
                    keeper |= currentBit;
                    bitCtr++;
                    //string tester = Convert.ToString(keeper, 2).PadLeft(8, '0');

                    if (bitCtr % 8 == 0)
                    {
                        Console.WriteLine(keeper);
                        bitCtr = 0;
                        keeper = 0;
                    }
                }
                index++;
            }
        }

        // printing last byte if necessery
        if (bitCtr > 0) 
        {
            keeper <<= (8 - bitCtr);
            Console.WriteLine(keeper);
        }
    }
}