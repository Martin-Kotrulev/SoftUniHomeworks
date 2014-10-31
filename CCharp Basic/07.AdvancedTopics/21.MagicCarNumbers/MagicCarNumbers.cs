using System;
//Problem 21.	** – Magic Car Numbers
//Cars in Sofia have registration numbers in format "CAabcdXY"
//where a, b, c and d are digits from 0 to 9 and X and Y are
//letters from the following subset of the Latin alphabet: 
//'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T' and 'X'. 
//Examples of car numbers from Sofia are "CA8517TX", "CA2277PC",
//"CA0710XC", "CA1111AC", while "CC7512FJ" in not valid car 
//number from Sofia. Local people are keen to choose special 
//numbers for their cars, know as magic car numbers. They 
//calculate the weight of a car number as follows: they sum
//its digits and letters, assuming that letters have the 
//following values: 'A'  10, 'B'  20, 'C'  30, 'E'  50, 
//'H'  80, 'K'  110, 'M'  130, 'P'  160, 'T'  200, 'X' 
// 240. For example the weight("CA6511BM") = 30 + 10 + 6 +
//5 + 1 + 1 + 20 + 130 = 203. A magic car number is a car 
//number that has a special magic weight (e.g. 256 or 512 
//for developers) and its number is in some of the formats 
//"CAaaaaXY", "CAabbbXY", "CAaaabXY", "CAaabbXY", "CAababXY"
//and "CAabbaXY", where a and b are two different digits and X
//and Y are letters from the Latin alphabet subset { 'A', 'B',
//'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' }.
//Your task is to write a program that calculates how many 
//cars ca	n be registered in Sofia for given magic weight.
//Input
//The input data should be read from the console. It will 
//consist of a single value: the magic weight.
//The input data will always be valid and in the format 
//described. There is no need to check it explicitly.
//Output
//The output should be printed on the console. It is a 
//single value: the number of cars matching given magic value.
//Constraints
//•	All input numbers will be integers in the range [1…1000].
//•	Allowed working time for your program: 0.25 seconds.
//•	Allowed memory: 16 MB.

// SOLUTION CHECKED - 100%

class MagicCarNumbers
{
    static int magicCtr = 0;
    static int magicNumber;
    static char[] letters = {'A', 'B', 'C', 'E',
                            'H', 'K', 'M', 'P', 'T', 'X'};

    static int GetCharValue(char c)
    {
        if (c >= '0' && c <= '9') return (c - '0');
        else return (10 * (c - 'A' + 1));
    }

    static void RegCheck(string registration)
    {
        int magicSum = 0;

        foreach (var c in registration) magicSum += GetCharValue(c);

        if (magicSum == magicNumber) magicCtr++;
    }

    static void Main()
    {
        magicNumber = int.Parse(Console.ReadLine());

        for (int l1 = 0; l1 < letters.Length; l1++)
        {
            for (int l2 = 0; l2 < letters.Length; l2++)
            {
                for (int a = 0; a < 10; a++)
                {
                    RegCheck("CA" + a + a + a + a + letters[l1] + letters[l2]);

                    for (int b = 0; b < 10; b++)
                    {
                        if (a != b)
                        {
                            RegCheck("CA" + a + a + b + b + letters[l1] + letters[l2]);
                            RegCheck("CA" + a + b + b + b + letters[l1] + letters[l2]);
                            RegCheck("CA" + a + a + a + b + letters[l1] + letters[l2]);
                            RegCheck("CA" + a + b + a + b + letters[l1] + letters[l2]);
                            RegCheck("CA" + a + b + b + a + letters[l1] + letters[l2]);
                        }
                    }
                }
            }
        }

        Console.WriteLine(magicCtr);
    }
}