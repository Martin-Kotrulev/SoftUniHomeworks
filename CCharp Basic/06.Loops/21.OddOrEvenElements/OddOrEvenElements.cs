using System;
//Problem 21.	** – Odd / Even Elements
//You are given N numbers. Calculate the sum, min and max 
//of its odd elements and sum, min and max of its even elements.
//Consider that the first element is odd, the second is even, etc.

//Input
//The input data should be read from the console.
//It will consists of exactly one line.
//•	At the first line N numbers will be given, 
//separated one from another by a single space.

//Output
//You have to print the output in a single line
//at the console in the following format:
//•	OddSum=…, OddMin=…, OddMax=…, EvenSum=…, EvenMin=…, EvenMax=…
//Print the numbers in the output without any unneeded trailing 
//zeroes (i.e. print 1.5 instead of 1.50; 1 instead of 1.00).
//In case the sum, the minimal or the maximal element cannot
//be calculated (due to missing data), print "No".

//SOLUTION CHECKED - 100%

class OddOrEvenElements
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.InvariantCulture;

        string input = Console.ReadLine().Trim();
        int len = input.Length;
        string[] n = input.Split(' ');

        decimal oddSum = 0;
        decimal oddMax = decimal.MinValue;
        decimal oddMin = decimal.MaxValue;

        decimal evenSum = 0;
        decimal evenMax = decimal.MinValue;
        decimal evenMin = decimal.MaxValue;

        if (len == 0) n = new string[0];

        for (int i = 0; i < n.Length; i++)
        {
            decimal current = decimal.Parse(n[i]);

            // odd
            if ((i & 1) == 0)
            {
                oddMax = Math.Max(oddMax, current);
                oddMin = Math.Min(oddMin, current);
                oddSum += current;
            }

            // even
            else
            {
                evenMax = Math.Max(evenMax, current);
                evenMin = Math.Min(evenMin, current);
                evenSum += current;
            }
        }

        if (n.Length == 0) Console.Write(
            "OddSum=No, OddMin=No, OddMax=No, ");
        else Console.Write(
            "OddSum={0:G29}, OddMin={1:G29}, OddMax={2:G29}, ",
            oddSum, oddMin, oddMax);
        if (n.Length < 2) Console.WriteLine(
            "EvenSum=No, EvenMin=No, EvenMax=No");
        else Console.WriteLine(
            "EvenSum={0:G29}, EvenMin={1:G29}, EvenMax={2:G29}",
            evenSum, evenMin, evenMax);
    }
}