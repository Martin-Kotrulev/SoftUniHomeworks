using System;
//Problem 4.	Print a Deck of 52 Cards
//Write a program that generates and prints all possible 
//cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation 
//(like 5♠, A♥, 9♣ and K♦). The card faces should start 
//from 2 to A. Print each card face in its four possible 
//suits: clubs, diamonds, hearts and spades. Use 2 nested 
//for-loops and a switch-case statement

class PrintDeckOf52Cards
{
    static string[] suits = { "\u2663", "\u2666", "\u2665", "\u2660" };

    static void Main()
    {
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 0; j < suits.Length; j++)
            {
                switch (i)
                {
                    case 11: Console.Write("A"); break;
                    case 12: Console.Write("J"); break;
                    case 13: Console.Write("Q"); break;
                    case 14: Console.Write("K"); break;
                    default: break;
                }
                if (i < 11) Console.Write(i);
                Console.Write(suits[j] + " ");
            }
            Console.WriteLine();
        }        
    }
}