using System;
using System.Text;
using System.Text.RegularExpressions;
//Problem 11.	Count of Letters
//Write a program that reads a list of letters and prints 
//for each letter how many times it appears in the list. 
//The letters should be listed in alphabetical order. Use
//the input and output format from the examples below. 

class CountTheLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] matches = new int[65536];
        input = Regex.Replace(input, @"\s+", string.Empty);

        for (int i = 0; i < input.Length; i++)
            matches[input[i]]++;

        for (int i = 0; i < matches.Length; i++)
        {
            if (matches[i] > 0) 
                Console.WriteLine("{0} -> {1}", (char)i, matches[i]);
        }
    }
}