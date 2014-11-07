using System;
//Problem 4 – Morse Code Numbers
//"Morse code" is a method of transmitting text information 
//as a series of on-off tones / lights / clicks / etc. 
//All symbols are represented by “.” (dots) and “-“ (dashes).
//You are given a 4-digit number n (1000 ≤ n ≤ 9999). First, 
//you have to calculate the sum of all digits of the number 
//n called nSum. Write a program to generate all sequences 
//of 6 numbers in the range 0…5, represented by their Morse 
//code encodings (0 = “-----”, 1 = “.----”, 2 = “..---”, 
//3 = “...--”, 4 = “....-”, 5 = “.....”), such that the 
//product of these 6 numbers is equal to nSum. This product 
//is called morseProduct. Put “|” (pipe) as a separator 
//after each Morse code digit. These sequences of strings 
//are called “Morse code numbers”. See the examples 
//below for better understanding.

//Input
//•	The input data should be read from the console.
//•	The number n stays at the first line.
//•	The input data will always be valid and in the 
//format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console as a sequence
//of strings (Morse code numbers), each at a separate line.
//The order of the output lines is not important. 
//In case no Morse code numbers exist, print “No”.

//Constraints
//•	The number n will be an integer number in the range [1000…9999].
//•	Allowed working time for your program: 0.25 seconds.
//•	Allowed memory: 16 MB.

// SOLUTION TESTED - 100%

class MorseCodeNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int nSum = CalculateDigitsSum(n);

        string[] morse = {"-----", ".----", "..---",
                              "...--", "....-", "....."};
        int[] digitMorse = { 0, 1, 2, 3, 4, 5 };
        bool matchFinded = false;

        int pos;
        while (true)
        {
            int currentProduct = CalculateArrayProduct(digitMorse);
            if (currentProduct == nSum)
            {
                PrintMorseCombination(digitMorse, morse);
                matchFinded = true;
            }
            pos = digitMorse.Length - 1;
            digitMorse[pos]++;
            while (digitMorse[pos] > 5)
            {
                digitMorse[pos] = 0;
                pos--;
                if (pos < 0)
                {
                    if (!matchFinded) Console.WriteLine("No");
                    return;
                }
                digitMorse[pos]++;
            }
        }
    }

    private static int CalculateDigitsSum(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }

    private static void PrintMorseCombination(int[] digitMorse, string[] morse)
    {
        for (int i = 0; i < digitMorse.Length; i++)
        {
            Console.Write(morse[digitMorse[i]] + '|');
        }
        Console.WriteLine();
    }

    private static int CalculateArrayProduct(int[] digitMorse)
    {
        int product = 1;
        foreach (var digit in digitMorse)
        {
            product *= digit;
        }

        return product;
    }
}