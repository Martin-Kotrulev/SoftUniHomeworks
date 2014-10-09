using System;
//Write a program that exchanges bits 3, 4 and 5 
//with bits 24, 25 and 26 of given 32-bit unsigned integer. 

class BitsExchange
{
    static int ExchangeBits(int n, int b1, int b2)
    {
        // in case bits on given position are the same do nothing
        if (((n >> b1) & 1 ^ (n >> b2) & 1) == 0) return n;
        else
        {
            // exchange 1 to 0 and 0 to 1
            n = ((n >> b1) & 1) == 1 ? n & ~(1 << b1) : n | (1 << b1);
            n = ((n >> b2) & 1) == 1 ? n & ~(1 << b2) : n | (1 << b2);
            return n;
        }
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

        for (int b1 = 3, b2 = 24; b1 <= 5; b1++, b2++)
        {
            n = ExchangeBits(n, b1, b2);
        }

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0') + "\n");
        Console.WriteLine(n);
    }
}