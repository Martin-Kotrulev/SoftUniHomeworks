using System;
//Problem 17.	* Calculate GCD
//Write a program that calculates the greatest 
//common divisor (GCD) of given two integers a 
//and b. Use the Euclidean algorithm (find it in Internet). 

// Short explanation: a = 1071; b = 462 
// 1071 mod 462  =  147
//          462 mod 147 =  21 <-- greatest common divisor
//          147 mod 21  =   0

class GreatestCommonDivisor
{
    static int divisionGCD(int a, int b)
    {
        while (b != 0)
        {
            int swap = b;
            b = a % b;
            a = swap;
        }
        return a;
    }

    static int recursiveGCD(int a, int b)
    {
        if (b == 0) return a;
        else return recursiveGCD(b, a % b);
    }

    static int subtractionGCD(int a, int b)
    {
        while (a != b)
        {
            if (a > b) a = a - b;
            else b = b - a;
        }
        return a;
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Divison GCD: {0}", divisionGCD(a, b));
        Console.WriteLine("Recursive GCD: {0}", recursiveGCD(a, b));
        Console.WriteLine("Subtraction GCD: {0}", subtractionGCD(a, b));
    }
}