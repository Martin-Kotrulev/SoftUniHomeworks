using System;
//Problem 4.	Rectangles
//Write an expression that calculates rectangle’s 
//perimeter and area by given width and height. 

class Rectangles
{
    static void GetRectangleProperties(
        double w, double h, out double a, out double p)
    {
        a = w * h;
        p = 2 * (w + h);
    }
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double heigh = double.Parse(Console.ReadLine());

        double a, p;
        GetRectangleProperties(width, heigh, out a, out p);

        Console.WriteLine("Area: {0}, Perimeter: {1}", a, p);
    }
}