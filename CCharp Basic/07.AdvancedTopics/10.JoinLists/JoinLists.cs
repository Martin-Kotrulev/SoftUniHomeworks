using System;
using System.Collections.Generic;
//Problem 10.	Join Lists
//Write a program that takes as input two lists of 
//integers and joins them. The result should hold 
//all numbers from the first list, and all numbers 
//from the second list, without repeating numbers, 
//and arranged in increasing order. The input and 
//output lists are given as integers, separated 
//by a space, each list at a separate line. 

class JoinLists
{
    static List<int> numbers = new List<int>();

    static void Main()
    {
        string[] first = Console.ReadLine().Split(' ');
        string[] second = Console.ReadLine().Split(' ');
        
        AddNumbersToList(first);
        AddNumbersToList(second);
        numbers.Sort();

        for (int i = 0; i < numbers.Count; i++)
            Console.Write(i == 0 ? "{0}" : " {0}", numbers[i]);
    }

    private static void AddNumbersToList(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (!numbers.Contains(int.Parse(arr[i])))
                numbers.Add(int.Parse(arr[i]));
        }
    }
}