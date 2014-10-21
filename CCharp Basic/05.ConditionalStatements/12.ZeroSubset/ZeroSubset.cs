using System;
using System.Collections.Generic;

namespace _12.ZeroSubset
{
    class ZeroSubset
    {
        static int[] n = new int[3];
        static bool[] check = { false, false, false, false, false };
        static List<int> subset = new List<int>();

        static void PrintSubset(List<int> subset)
        {
            for (int i = 0; i < subset.Count; i++)
            {
                Console.Write(subset[i] +
                    (i == subset.Count - 1 ? " = 0\n" : " + "));
            }
            subset.Clear();
        }

        static void CheckSubset(List<int> subset)
        {
            int sum = 0;
            foreach (var item in subset)
            {
                sum += item;
            }
            if (sum == 0) PrintSubset(subset);
        }

        static void GetSubsetSum(int i)
        {
            if (i == n.Length) return;

            for (int j = 0; j < n.Length; i++)
            {
                if (!check[j])
                {
                    subset.Add(n[j]);
                    check[j] = true;
                }
                CheckSubset(subset);
                GetSubsetSum(i + 1);
                check[j] = false;
            }
        }

        static void Main()
        {
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }

            GetSubsetSum(0);
        }
    }
}