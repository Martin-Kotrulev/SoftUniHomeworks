using System;
//Problem 11.	Bitwise: Extract Bit #3
//Using bitwise operators, write an expression for finding 
//the value of the bit #3 of a given unsigned integer. 
//The bits are counted from right to left, starting from bit #0. 
//The result of the expression should be either 1 or 0. 

class ExtractBit3
{
    static int ExtractThirdBit(int n)
    {
        return ((n >> 2) & 1) == 1 ? 1 : 0;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(ExtractThirdBit(n));
    }
}