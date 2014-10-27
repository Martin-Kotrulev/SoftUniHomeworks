using System;
//Problem 15.	Hexadecimal to Decimal Number
//Using loops write a program that converts a 
//hexadecimal integer number to its decimal form. 
//The input is entered as string. The output 
//should be a variable of type long. 
//Do not use the built-in .NET functionality. 

class HexToDec
{
    static void Main()
    {
        string hex = Console.ReadLine();
        long dec = 0;

        for (int i = 0; i < hex.Length; i++)
        {
            int current = hex[i] - '0';
            if (current > 9) current -= 7; // correct representation

            dec += current * (long)Math.Pow(16, (hex.Length - 1) - i);
        }

        Console.WriteLine(dec);
    }
}