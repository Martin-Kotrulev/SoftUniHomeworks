using System;
//Problem 9.	Trapezoids
//Write an expression that calculates trapezoid's 
//area by given sides a and b and height h. 

class TrapezoidArea
{
    static double GetTrapezoidArea(double b1, double b2, double h)
    {
        //direct implementation of the formula
        return ((b1 + b2) / 2) * h;
    }

    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine(GetTrapezoidArea(a, b, h));
    }
}