using System;
//Problem 4 – Bulls and Cows
//All we love the “Bulls and Cows” game 
//(http://en.wikipedia.org/wiki/Bulls_and_cows).
//Given a 4-digit secret number and a 4-digit guess number 
//we say that we have b bulls and c cows when we have b 
//matching digits on their right positions (bulls) and c 
//matching digits on different positions (cows).
//Given the secret number and the number of bulls and
//cows your task is to write a program to find all 
//matching guess numbers in increasing order.

//Input
//•	The input data should be read from the console.
//•	It will consist of exactly 3 lines. At the first 
//line there the secret number will be given. At the 
//second line the number of bulls b will be given. At
//the third line the number of cows c will be given.
//•	The input data will always be valid and in the 
//format described. There is no need to check it explicitly.

//Output
//•	The output data should be printed on the console
//•	It should consist of a single line holding all 
//matched guess numbers, given in increasing order, 
//separated by single space.

//Constraints
//•	The secret number will always consist of 
//exactly 4 digits, each in the range [1…9].
//•	The numbers b and c will be in the range [0…9].
//•	Time limit: 0.15 seconds.
//•	Allowed memory: 4 MB.

// SOLUTION CHECKED - 100%

class BullsAndCows
{
    static bool NumberIsValid(string s, string n, int bulls, int cows)
    {
        int b = 0;
        int c = 0;
        char[] secret = s.ToCharArray();
        char[] guess = n.ToCharArray();

        // bulls
        for (int i = 0; i < secret.Length; i++)
        {
            if (secret[i] == guess[i])
            {
                b++;
                secret[i] = 'B';
                guess[i] = 'b';
            }
        }
        // cows
        for (int i = 0; i < secret.Length; i++)
        {
            for (int j = 0; j < guess.Length; j++)
            {
                if (secret[i] == guess[j])
                {
                    c++;
                    secret[i] = 'C';
                    guess[j] = 'c';
                }
            }
        }

        return b == bulls && c == cows;
    }

    static void Main()
    {
        string secret = Console.ReadLine();
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        int ctr = 0;
        bool firstPrinted = false;

        for (int i = 1111; i <= 9999; i++)
        {
            string current = Convert.ToString(i);
            if (current[0] == '0' || current[1] == '0' ||
                current[2] == '0' || current[3] == '0') continue;

            if (NumberIsValid(current, secret, bulls, cows))
            {
                Console.Write((firstPrinted ? " ": "") + i);
                firstPrinted = true;
                ctr++;
            }
        }
        if (ctr == 0) Console.WriteLine("No");
    }
}