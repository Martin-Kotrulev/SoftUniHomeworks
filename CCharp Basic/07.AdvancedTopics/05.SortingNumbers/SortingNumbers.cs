using System;
using System.Collections.Generic;
//Problem 5.	Sorting Numbers
//Write a program that reads a number n and a 
//sequence of n integers, sorts them and prints them

class SortingNumbers
{
    static List<int> QuickSort(List<int> list)
    {
        if (list.Count <= 1) return list;

        // choosing comparing element
        int pivot = list.Count / 2;
        int pivotValue = list[pivot];
        list.RemoveAt(pivot);

        // splitiing the list into two sublists
        List<int> lesser = new List<int>();
        List<int> greater = new List<int>();

        foreach (var element in list)
        {
            if (element <= pivotValue) lesser.Add(element);
            else greater.Add(element);
        }

        // recursive building
        List<int> result = new List<int>();

        result.AddRange(QuickSort(lesser));
        result.Add(pivotValue);
        result.AddRange(QuickSort(greater));

        return result;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();

        for (int i = 0; i < n; i++)
            list.Add(int.Parse(Console.ReadLine()));

        list = QuickSort(list);

        foreach (var num in list)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}