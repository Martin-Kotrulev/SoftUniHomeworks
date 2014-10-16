using System;
// SOLUTION CHECKED - 100% P.S. I'm very proud of it!

class MagicStrings
{
    static char[] chars = {'k', 'n', 'p', 's'};
    static char[] first;
    static char[] second;
    static int n;
    static int combinations;

    static int PermutationSum(char[] permutation)
    {
        int sum = 0;
        foreach (var item in permutation)
        {
            switch (item)
            {
                case 'k': sum += 1; break;
                case 'n': sum += 4; break;
                case 'p': sum += 5; break;
                case 's': sum += 3; break;
                default: break;
            }
        }
        return sum;
    }

    static void PermutateRecursiveSecond(int currentLoop)
    {
        if (currentLoop == chars.Length)
        {
            int fSum = PermutationSum(first);
            int sSum = PermutationSum(second);
            if (Math.Abs(fSum - sSum) == n)
            {
                PrintCombination(first, second);
                combinations++;
            }
            return;
        }

        for (int i = 0; i < chars.Length; i++)
        {
            second[currentLoop] = chars[i];
            PermutateRecursiveSecond(currentLoop + 1);
        }
    }

    static void PermutateRecursiveFirst(int currentLoop)
    {
        // recursion bottom
        if (currentLoop == chars.Length)
        {
            PermutateRecursiveSecond(0);
            return;
        }

        for (int i = 0; i < chars.Length; i++)
        {
            first[currentLoop] = chars[i];
            PermutateRecursiveFirst(currentLoop + 1);
        }
    }

    static void PrintCombination(char[] first, char[] second)
    {
        foreach (var item in first)
        {
            Console.Write(item);
        }
        foreach (var item in second)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        combinations = 0;
        first = new char[chars.Length];
        second = new char[chars.Length];

        PermutateRecursiveFirst(0);

        if (combinations == 0) Console.WriteLine("No");
    }
}