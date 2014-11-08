using System;
using System.Collections.Generic;
//Problem 12.	Count of Names
//Write a program that reads a list of names and prints 
//for each name how many times it appears in the list. 
//The names should be listed in alphabetical order. Use 
//the input and output format from the examples below.

class CountOfNames
{
    static void Main(string[] args)
    {
        Dictionary<string, int> names = new Dictionary<string, int>();
        string[] input = Console.ReadLine().Split(' ');

        for (int i = 0; i < input.Length; i++)
        {
            if (names.ContainsKey(input[i])) names[input[i]]++;
            else names.Add(input[i], 1);
        }

        foreach (var item in names)
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
    }
}