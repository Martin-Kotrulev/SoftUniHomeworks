using System;
//Problem 12.	Extract Bit from Integer
//Write an expression that extracts from given 
//integer n the value of given bit at index p. Examples:

class ExtractBitFromInteger
{
    static int ExtractBit(int n, int p)
    {
        return ((n >> p) & 1) == 1 ? 1 : 0;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine(ExtractBit(n, p));
    }
}