using System;
// ******   ******
// *////*|||*////* -- 3
// ******   ******

// **********     **********
// *////////*     *////////*
// *////////*|||||*////////* -- 5
// *////////*     *////////*
// **********     **********

// SOLUTION TESTED - 100%
class Sunglasses
{
    static void Main(string[] args)
    {
        int oddN = int.Parse(Console.ReadLine());
        for (int row = 1; row <= oddN; row++)
        {
            if (row == 1 || row == oddN)
            {
                for (int pos = 1; pos++ <= oddN * 2; Console.Write("*")) ; // left part
                for (int pos = 1; pos++ <= oddN; Console.Write(" ")) ; // center part
                for (int pos = 1; pos++ <= oddN * 2; Console.Write("*")) ; // right part
                Console.WriteLine();
            }
            else
            {
                Console.Write("*");
                for (int pos = 1; pos++ <= oddN * 2 - 2; Console.Write("/")) ; // left part
                Console.Write("*");
                if (row == oddN / 2 + 1) for (int pos = 1; pos++ <= oddN; Console.Write("|")) ; // the frame
                else for (int pos = 1; pos++ <= oddN; Console.Write(" ")) ;
                Console.Write("*");
                for (int pos = 1; pos++ <= oddN * 2 - 2; Console.Write("/")) ; // right
                Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}