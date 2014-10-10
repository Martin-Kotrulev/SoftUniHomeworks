using System;
//You will be given an integer, representing the bits to sieve, 
//and several more numbers, representing the sieves the bits will 
//fall through. Your task is to follow the bits as they fall down, 
//and determine what comes out of the other end.
// output: the number of the bits
// SOLUTION CHECKED 100%

class BitSifting
{
    static void Main()
    {
        ulong b = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        ulong bitsCtr = 0;

        for (int i = 0; i < n; i++)
        {
            ulong sieve = ulong.Parse(Console.ReadLine());
            b &= ~sieve; // same as (a ^ b) & a shifting bits
        }

        while (b != 0)
        {
            bitsCtr += b & 1; // adding rightmost bit
            b >>= 1;
        }
        Console.WriteLine(bitsCtr);
    }
}