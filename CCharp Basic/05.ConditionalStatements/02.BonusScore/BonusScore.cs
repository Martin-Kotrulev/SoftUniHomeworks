﻿using System;
//Problem 2.	Bonus Score
//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//•	If the score is between 1 and 3, the program multiplies it by 10.
//•	If the score is between 4 and 6, the program multiplies it by 100.
//•	If the score is between 7 and 9, the program multiplies it by 1000.
//•	If the score is 0 or more than 9, the program prints “invalid score”.

class BonusScore
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());

        if(score > 0 && score < 10)
        {
            score *= 10;
            if (score > 3) score *= 10;
            if (score > 6) score *= 10;
        }
        else Console.WriteLine("Invalid score!");
    }
}