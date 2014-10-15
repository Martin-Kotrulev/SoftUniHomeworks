using System;
//Problem 3.	Circle Perimeter and Area
//Write a program that reads the radius r of a circle 
//and prints its perimeter and area formatted 
//with 2 digits after the decimal point


class CirclePerimeterAndArea
{
    public class Circle
    {
        public double r;
    }

    static double GetCircleArea(Circle circle)
    { return 2 * Math.PI * circle.r; }

    static double GetCirclePerimeter(Circle circle)
    { return Math.PI * (circle.r * circle.r); }

    static void Main()
    {
        Circle myCircle = new Circle();
        myCircle.r = double.Parse(Console.ReadLine());

        Console.WriteLine("Perimeter: {0:F2}", GetCirclePerimeter(myCircle));
        Console.WriteLine("Area: {0:F2}", GetCircleArea(myCircle));
    }
}