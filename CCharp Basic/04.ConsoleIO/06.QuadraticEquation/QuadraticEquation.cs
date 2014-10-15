using System;
//Problem 6.	Quadratic Equation
//Write a program that reads the coefficients a, b and c 
//of a quadratic equation ax2 + bx + c = 0 and solves 
//it (prints its real roots). 

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        // finding discriminant
        double d = (b * b) - (4 * a * c);

        if (d < 0 || a == 0.0)
        {
            Console.WriteLine("No real roots!");
        }
        else
        {
            Console.WriteLine("x1={0}; x2={1}",
                (-b - Math.Sqrt(d)) / (2 * a),
                (-b + Math.Sqrt(d)) / (2 * a));
        }
    }
}