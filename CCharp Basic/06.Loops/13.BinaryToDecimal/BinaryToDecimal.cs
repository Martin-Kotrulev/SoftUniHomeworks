using System;
//Problem 13.	Binary to Decimal Number
//Using loops write a program that converts a 
//binary integer number to its decimal form. 
//The input is entered as string. The output 
//should be a variable of type long. 
//Do not use the built-in .NET functionality. 

// Explanation: powers of two:      64  32  16  8  4  2  1
//              bit representation: 1   1   0   0  0  1  1
// adding only powers with bit representation of 1:
// 64 + 32 + 2 + 1 = 99 --> 1100011 in decimal is 99 

class BinaryToDecimal
{
    static void Main()
    {
        string binary = Console.ReadLine();
        long dec = 0;
        int binaryCtr = 1 << binary.Length;

        for (int i = 0; i < binary.Length; i++)
        {
            binaryCtr >>= 1;
            if (binary[i] - '0' == 1) dec += binaryCtr; 
        }

        Console.WriteLine(dec);
    }
}