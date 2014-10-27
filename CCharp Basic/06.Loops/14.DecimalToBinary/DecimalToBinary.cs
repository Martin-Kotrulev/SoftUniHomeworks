using System;
//Problem 14.	Decimal to Binary Number
//Using loops write a program that converts an integer
//number to its binary representation. The input is 
//entered as long. The output should be a variable 
//of type string. Do not use the built-in .NET functionality. 

class DecimalToBinary
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
        long num = int.Parse(Console.ReadLine());
        string binary = "";

        while (num > 0)
        {
            binary += num % 2;
            num /= 2;
        }

        binary = ReverseString(binary);

        Console.WriteLine(binary);
    }
}