using System;
//Problem 16.	Decimal to Hexadecimal Number
//Using loops write a program that converts an integer 
//number to its hexadecimal representation. The input
//is entered as long. The output should be a variable
//of type string. Do not use the built-in .NET functionality. 

class DecToHex
{
    static string ReverseString(string s)
    {
        string n = "";

        for (int i = s.Length - 1; i >= 0; i--)
        {
            n += s[i];
        }

        return n;
    }

    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        string hex = "";

        while (num > 0)
        {
            long reminder = num % 16;
            if (reminder > 9) hex += (char)(reminder + '0' + 7);
            else hex += reminder;
            num /= 16;
        }

        hex = ReverseString(hex);

        Console.WriteLine(hex);
    }
}