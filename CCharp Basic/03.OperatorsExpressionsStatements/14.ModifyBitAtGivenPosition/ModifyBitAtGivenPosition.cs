using System;
//Problem 14.	Modify a Bit at Given Position
//We are given an integer number n, a bit value v (v=0 or 1) 
//and a position p. Write a sequence of operators 
//(a few lines of C# code) that modifies n to hold 
//the value v at the position p from the binary 
//representation of n while preserving all other bits in n. 

    class ModifyBitAtGivenPosition
    {
        static int ModifyBitOnPos(int n, int p, int v)
        {
            // if v = 0 using & combined with ~ example: 
            //b1000 & ~(b0001 << 3)--> 1000 & 0111 = 0000
            return v == 0 ? n & ~(1 << p) : n | (1 << p);
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            Console.WriteLine(ModifyBitOnPos(n, p, v));
        }
    }