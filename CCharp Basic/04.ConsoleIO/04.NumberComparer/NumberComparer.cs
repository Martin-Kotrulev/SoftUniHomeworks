using System;
//Problem 4.	Number Comparer
//Write a program that gets two numbers from the 
//console and prints the greater of them. 
//Try to implement this without if statements

class NumberComparer
{
    static int IflessCompare(int a, int b)
    {
        return (a + b + Math.Abs(a - b)) / 2;
    }

    static int BitwiseCompare(int a, int b)
    {
        return a - ((a - b) & ((a - b) >> 31));
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Bitwise Greater: {0}", BitwiseCompare(a, b));
        Console.WriteLine("Greater: {0}", IflessCompare(a, b));
        Console.WriteLine(Convert.ToString(3 - -2, 2).PadLeft(32, '0'));
    }
}