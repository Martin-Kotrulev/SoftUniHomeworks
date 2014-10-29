using System;
using System.Collections.Generic;
//Problem 23.	** – Five Special Letters
//We are given two numbers: start and end. Write 
//a program to generate all sequences of 5 letters,
//each from the set { 'a', 'b', 'c', 'd', 'e' }, 
//such that the weight of these 5 letters is a numbe
//r in the range [start … end] inclusively. Print 
//them in alphabetical order, in a single line, 
//separated by a space.
//The weight of a single letter is calculated as 
//follows:  weight('a') = 5; weight('b') = -12;  
//weight('c') = 47;  weight('d') = 7;  weight('e') = -32.
//The weight of a sequence of letters c1c2…cn is the 
//calculated by first removing all repeating letters 
//(from right to left) and then calculate the formula:
//weight(c1c2…cn) = 1*weight(c1) + 2*weight(c2) + … + n*weight(cn)
//For example, the weight of "bcddc" is calculated as follows:
//First we remove the repeating letters and we get "bcd". Then
//we apply the formula: 1*weight('b') + 2*weight('c') + 3*weight('d') =
//1*(-12) + 2*47 + 3*7 = 103. Another example: weight("cadea") = 
//weight("cade") = 1*47 + 2*5 + 3*7 - 4*32 = -50.

//Input
//The input data should be read from the console. 
//It will consist of 2 lines:
//•	The number start stays at the first line.
//•	The number end stays at the second line.
//The input data will always be valid and in the 
//format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console as 
//a sequence of strings in alphabetical order. 
//Each string should be separated than the next 
//string by a single space. In case no 5-letter 
//strings exist with a weight in the specified range, print “No”.

//SOLUTION TESTED - 100%;

class FiveSpecialLetters
{
    static int start = int.Parse(Console.ReadLine());
    static int end = int.Parse(Console.ReadLine());
    static Stack<char> seq = new Stack<char>();
    static Dictionary<char, int> weights = new Dictionary<char, int>();
    static string output = string.Empty;

    static void AddSeq(Stack<char> seq)
    {
        foreach (var c in seq) output += c;
        output += " ";
    }

    static string BuildValidSeq(Stack<char> seq)
    {
        Dictionary<char, bool> check = new Dictionary<char, bool>();
        string currentSeq = "";

        check['a'] = false;
        check['b'] = false;
        check['c'] = false;
        check['d'] = false;
        check['e'] = false;

        foreach (var c in seq)
        {
            if (!check[c])
            {
                currentSeq += c;
                check[c] = true;
            }
        }

        return currentSeq;
    }

    static void CalcSeqWeight(Stack<char> seq)
    {
        string validSeq = BuildValidSeq(seq);
        int seqWeight = 0;

        for (int i = 0; i < validSeq.Length; i++)
        {
            seqWeight += (i + 1) * weights[validSeq[i]];
        }

        if (seqWeight >= start && seqWeight <= end) AddSeq(seq);
    }

    static void GenerateSeq(int loops)
    {
        if (loops == 0) // recursion base
        {
            CalcSeqWeight(seq);
            return;
        }

        for (char i = 'a'; i <= 'e'; i++)
        {
            seq.Push(i);
            GenerateSeq(loops - 1);
            seq.Pop(); // backtrack
        }
    }

    static void Main()
    {
        weights['a'] = 5;
        weights['b'] = -12;
        weights['c'] = 47;
        weights['d'] = 7;
        weights['e'] = -32;

        GenerateSeq(weights.Count);

        output = output.Trim();
        
        if (output.Length > 0)
        {
            string[] arr = output.Split(' ');
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] +
                    (i == arr.Length - 1 ? "\n" : " "));
            }
        }
        else Console.WriteLine("No");
    }
}