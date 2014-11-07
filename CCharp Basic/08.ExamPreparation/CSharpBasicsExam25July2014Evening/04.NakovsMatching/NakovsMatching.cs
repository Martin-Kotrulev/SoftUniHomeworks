using System;
//Problem 4 – Nakovs Matching
//We are given two words a and b. Each word can be split 
//in several ways into left and right side:
//•	a = (aLeft|aRight)
//•	b = (bLeft|bRight)
//The weight w(s) of given character sequence s is calculated
//as sum of the ASCII codes of its characters. The Nakov's
//distance between two split words (aLeft|aRight) and 
//(bLeft|bRight) is defined as:
//•	nakovs = w(aLeft) * w(bRight) - w(aRight) * w(bLeft),
//as absolute value
//We assume that two word splits have good matching if 
//their Nakov's difference is not greater than given 
//limit number d. Your task is to write a program that 
//prints all good matchings between given two words a 
//and b and given limit number d.
//Example: a = "hello", b = "csharp", d = 20000. The word
//a can be split in 4 ways: "h|ello", "he|llo","hel|lo" 
//and "hell|o". The word b can be split in 5 ways: "c|sharp",
//"cs|harp", "csh|arp", "csha|rp" and "cshar|p". 
//There are 20 possible matchings between the words a and b, 
//but only 3 of them are good matchings (nakovs ≤ d):

// SOLUTION TESTED - 100%

class NakovsMatching
{
    static int CalculateStringWeight(string s)
    {
        int sum = 0;
        for (int i = 0; i < s.Length; i++) sum += s[i];

        return sum;
    }

    static void Main(string[] args)
    {
        string wordA = Console.ReadLine();
        string wordB = Console.ReadLine();
        int d = int.Parse(Console.ReadLine());
        bool match = false;

        for (int splitA = 1; splitA < wordA.Length; splitA++)
        {
            // build left and right side of word A
            string leftA = "";
            string rightA = "";
            for (int ctr = 0; ctr < wordA.Length; ctr++)
            {
                if (ctr < splitA) leftA += wordA[ctr];
                else rightA += wordA[ctr];
            }
            // calculate weight
            int weightLeftA = CalculateStringWeight(leftA);
            int weightRightA = CalculateStringWeight(rightA);

            for (int splitB = 1; splitB < wordB.Length; splitB++)
            {
                // Build left and right side of word B
                string leftB = "";
                string rightB = "";
                for (int ctr = 0; ctr < wordB.Length; ctr++)
                {
                    if (ctr < splitB) leftB += wordB[ctr];
                    else rightB += wordB[ctr];
                }
                int weightLeftB = CalculateStringWeight(leftB);
                int weightRightB = CalculateStringWeight(rightB);

                long nakovs = Math.Abs(
                    weightLeftA * weightRightB - weightRightA * weightLeftB);

                if (nakovs <= d)
                {
                    Console.WriteLine(
                    "({0}|{1}) matches ({2}|{3}) by {4} nakovs",
                    leftA, rightA, leftB, rightB, nakovs);
                    match = true;
                }
            }
        }
        if (!match) Console.WriteLine("No");
    }
}