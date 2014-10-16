using System;
// SOLUTION CHECKED - 100% 
// Warning - only for refference how works permutation method
// this is wrong way

class MagicStrings
{
    static int PermutationSum(string permutation)
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

    static void Main()
    {
        // making sure the alphabetical order in the array
        char[] chars = {'k', 'n', 'p', 's'};
        int combinations = 0;
        int n = int.Parse(Console.ReadLine());

        for (int c1 = 0; c1 < chars.Length; c1++)
        {
            for (int c2 = 0; c2 < chars.Length; c2++)
            {
                for (int c3 = 0; c3 < chars.Length; c3++)
                {
                    for (int c4 = 0; c4 < chars.Length; c4++)
                    {
                        string first = "" + chars[c1] + chars[c2] + chars[c3] + chars[c4];
                        int fSum = PermutationSum(first);

                        for (int c5 = 0; c5 < chars.Length; c5++)
                        {
                            for (int c6 = 0; c6 < chars.Length; c6++)
                            {
                                for (int c7 = 0; c7 < chars.Length; c7++)
                                {
                                    for (int c8 = 0; c8 < chars.Length; c8++)
                                    {
                                        string second = ""+ chars[c5] + chars[c6] + chars[c7] + chars[c8];
                                        int sSum = PermutationSum(second);

                                        if (Math.Abs(fSum - sSum) == n)
                                        {
                                            Console.WriteLine(first + second);
                                            combinations++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }          
        }

        if (combinations == 0) Console.WriteLine("No");
    }
}