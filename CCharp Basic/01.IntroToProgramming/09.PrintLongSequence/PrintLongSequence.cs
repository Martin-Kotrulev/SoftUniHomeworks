using System;
/// <summary>
/// Problem 16:
/// Write a program that prints the first 1000 members of the sequence: 
/// 2, -3, 4, -5, 6, -7, … You might need to learn how to use loops in C# (search in Internet).
/// </summary>
class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1002; i++)
        {
            // checking for odd using bitwise method
            Console.WriteLine((i & 1) == 0 ? "{0}" : "-{0}", i);
        }
    }
}

