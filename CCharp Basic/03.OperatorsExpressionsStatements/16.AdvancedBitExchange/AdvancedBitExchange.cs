using System;
//Problem 16.	** Bit Exchange (Advanced)
//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits 
//{q, q+1, …, q+k-1} of a given 32-bit unsigned integer. 
//The first and the second sequence of bits may not overlap. 

class AdvancedBitExchange
{
    static int ReadNumber()
    {
        int n;
        int.TryParse(Console.ReadLine(), out n);
        return n;
    }

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
        int n = ReadNumber();
        int p = ReadNumber();
        int q = ReadNumber();
        int k = ReadNumber();
        int pStart = p;
        int qStart = q;

        // determine the lower position of bits
        if (q < p)
        {
            p = qStart;
            q = pStart;
            pStart = p;
            qStart = q;
        }

        while (k-- != 0)
        {
            if (n == 0) // in case tryParse return 0: invalid
            {
                Console.WriteLine("Out of range!"); return;
            }
            else if (p >= qStart)
            {
                Console.WriteLine("Overlapping!"); return;
            }

            try
            {
                n = ExchangeBits(n, p++, q++);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Out of range!");
                return;
            }
        }
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine(n);
    }
}