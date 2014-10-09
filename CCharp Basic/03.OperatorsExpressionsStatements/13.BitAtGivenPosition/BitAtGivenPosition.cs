using System;
//Problem 13.	Check a Bit at Given Position
//Write a Boolean expression that returns if the 
//bit at position p (counting from 0, starting from the right) 
//in given integer number n has value of 1. 

class BitAtGivenPosition
{
    static bool IsOneOnPosP(int n, int p)
    {
        // ((1 moved to p) & number) moved back again p position
        return (((1 << p) & n) >> p) == 1;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine(IsOneOnPosP(n, p));
    }
}