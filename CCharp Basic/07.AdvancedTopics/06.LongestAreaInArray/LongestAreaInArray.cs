using System;
using System.Collections.Generic;
//Problem 6.	Longest Area in Array
//Write a program to find the longest area of 
//equal elements in array of strings. You first 
//should read an integer n and n strings 
//(each at a separate line), then find and print 
//the longest sequence of equal elements 
//(first its length, then its elements). 
//If multiple sequences have the same 
//maximal length, print the leftmost of them. 

class LongestAreaInArray
{
    static int bestLen = 1;

    static string[] InputArrayValue(int valuesCount)
    {
        string[] arr = new string[valuesCount];
        for (int i = 0; i < valuesCount; i++) 
            arr[i] = Console.ReadLine();

        return arr;
    }

    static string GetBestStringValue(string[] arr)
    {
        string bestString = arr[0];

        for (int i = 1, currLen = 1; i < arr.Length; i++)
        {
            currLen = arr[i - 1] == arr[i] ? currLen + 1 : 1;

            if (currLen > bestLen)
            {
                bestLen = currLen;
                bestString = arr[i];
            }
            else if (currLen == bestLen)
            {
                if (arr[i].Length > bestString.Length)
                {
                    bestString = arr[i];
                }
            }
        }

        return bestString;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] arr = InputArrayValue(n);
        string bestString = GetBestStringValue(arr);

        Console.WriteLine(bestLen);

        foreach (var item in arr)
        {
            if (item == bestString) Console.WriteLine(item);
        }
    }
}