using System;
using System.Linq;
//Problem 2 – Letters, Symbols, Numbers 
//You are given N strings. Every string consists of letters,
//symbols, numbers and whitespace. All letters (a-z) and 
//(A-Z) have values corresponding to their position in 
//the English alphabet * 10 (a = 10, A = 10, b = 20, 
//B = 20, …, z = 260, Z = 260). All symbols (like 
//`~!@#$%^&*()_+{}:"|<>?-=[];'\,./) have a fixed value
//of 200 and all numbers have the value of their digit
//* 20 (0 = 0, 1 = 20, 2 = 40, 3 = 60, …, 9 = 180). 
//The whitespace is ignored. Your task is to calculate
//the sum of all letters, all symbols and all numbers 
//from the input and print them, each at a separate line.

//Input
//The input data should be read from the console.
//•	At the first line an integer number N is given, 
//specifying the count of the input strings.
//•	Each of the next N lines holds an input string.
//The input data will always be valid and in the 
//format described. There is no need to check it explicitly.

//Output
//The output should be printed on the console. It should consist of exactly 3 lines:
//•	On the first line print the sum of all letters.
//•	On the second line print the sum of all numbers.
//•	On the third line print the sum of all symbols.

// SOLUTION CHECKED - 100%

static class LettersSymbolsNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int lettersSum = 0, symbolsSum = 0, digitsSum = 0;
        for (int i = 0; i < n; i++)
        {
            string current = Console.ReadLine();
            current = RemoveWhiteSpace(current);
            CalculateStringValue(
                current, ref lettersSum, ref digitsSum, ref symbolsSum);
        }

        Console.WriteLine(lettersSum);
        Console.WriteLine(digitsSum);
        Console.WriteLine(symbolsSum);
    }

    private static string RemoveWhiteSpace(this string s)
    {
        return new string(
            s.ToCharArray().Where(
            c => !Char.IsWhiteSpace(c)).ToArray());
    }

    private static void CalculateStringValue(
        string s, ref int lettersSum, ref int digitsSum, ref int symbolsSum)
    {
        s = s.ToLower();
        foreach (var c in s)
        {
            if (c >= 'a' && c <= 'z') lettersSum += ((c - 'a') + 1) * 10;
            else if (c >= '0' && c <= '9') digitsSum += (c - '0') * 20;
            else symbolsSum += 200;
        }
    }
}