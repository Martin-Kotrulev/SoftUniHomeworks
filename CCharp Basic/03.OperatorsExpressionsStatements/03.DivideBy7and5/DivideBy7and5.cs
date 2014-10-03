using System;
//Problem 3.	Divide by 7 and 5
//Write a Boolean expression that checks for given integer if 
//it can be divided (without remainder) by 7 and 5 in the same time. 

class DivideBy7and5
{
    static bool IfDivisable(int n)
    {
        return n % 7 * 5 == 0;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(IfDivisable(n));
    }
}