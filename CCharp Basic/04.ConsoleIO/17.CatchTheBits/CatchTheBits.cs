using System;
//You are given a sequence of bytes. Consider each byte as sequence of exactly 8 bits. 
//You are given also a number step. Write a program to extract all the bits at positions: 
//1, 1 + step, 1 + 2*step, ... Print the output as a sequence of bytes. 
//In case the last byte have less than 8 bits, add trailing zeroes at its right end. Bits in each byte 
//are counted from the leftmost to the rightmost. Bits are numbered starting from 0.
//SOLUTION TESTED -  100%

class CatchTheBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        int bitsCount = 0; //todo: shift first to rightmost
        int keeper = 0;
        //string tester = Convert.ToString(keeper, 2).PadLeft(8, '0');

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            for (int bit = 7; bit >= 0 ; bit--)
            {
                if ((step == 1 && index > 0) || (index % step == 1))
                {
                    keeper <<= 1;
                    keeper |= (num >> bit) & 1;
                    bitsCount++;
                    //tester = Convert.ToString(keeper, 2).PadLeft(8, '0');

                    if (bitsCount % 8 == 0)
                    {
                        Console.WriteLine(keeper);
                        bitsCount = 0;
                        keeper = 0;
                    }
                }
                index++;
            }
        }
        // if there's anoter byte
        if (bitsCount > 0)
        {
            keeper <<= (8 - bitsCount);
            Console.WriteLine(keeper);
        }
    }
}