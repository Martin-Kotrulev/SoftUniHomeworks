﻿using System;
using System.Numerics;
//Problem 2 – Tribonacci
//The Tribonacci sequence is a sequence in which every
//next element is made by the sum of the previous 
//three elements from the sequence.

//Write a computer program that finds the Nth element
//of the Tribonacci sequence, if you are given the 
//first three elements of the sequence and the number
//N. Mathematically said: with given T1, T2 and T3 – 
//you must find Tn.

//Input
//•	The input data should be read from the console.
//•	The values of the first three Tribonacci elements
//will be given on the first three input lines.
//•	The number N will be on the fourth line. This is 
//the number of the consecutive element of the sequence 
//that must be found by your program.
//•	The input data will always be valid and in the format 
//described. There is no need to check it explicitly.

//Output
//•	The output data should be printed on the console.
//•	At the only output line you must print the Nth 
//element of the given Tribonacci sequence.

//Constraints
//•	The values of the first three elements of the 
//sequence will be integers between -2 000 000 000 and 2 000 000 000.
//•	The number N will be a positive integer between 1 and 15 000, inclusive.
//•	Time limit: 0.25 seconds.
//•	Allowed memory: 16 MB.

class SimpleLoops
{
    static BigInteger FindNthTribonnacci(
        BigInteger t1, BigInteger t2, BigInteger t3, BigInteger nth)
    {
        if (nth < 4)
        {
            switch ((int)nth)
            {
                case 1: return t1;
                case 2: return t2;
                case 3: return t3;
            }
        }

        BigInteger nthTribonacci = 0;
        for (int i = 4; i <= nth; i++)
        {
            nthTribonacci = t1 + t2 + t3;
            t1 = t2;
            t2 = t3;
            t3 = nthTribonacci;
        }
        return nthTribonacci;
    }

    static void Main()
    {
        BigInteger t1 = BigInteger.Parse(Console.ReadLine());
        BigInteger t2 = BigInteger.Parse(Console.ReadLine());
        BigInteger t3 = BigInteger.Parse(Console.ReadLine());
        BigInteger nth = BigInteger.Parse(Console.ReadLine());

        Console.WriteLine(FindNthTribonnacci(t1, t2, t3, nth));
    }
}