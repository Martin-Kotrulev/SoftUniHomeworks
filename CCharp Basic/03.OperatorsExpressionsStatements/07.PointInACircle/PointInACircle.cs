using System;
//Problem 7.	Point in a Circle
//Write an expression that checks if given 
//point (x,  y) is inside a circle K({0, 0}, 2). 

public class Point
{
    public double x;
    public double y;
}
public class Circle
{
    public Point center = new Point();
    public double radius;
    public Circle()
    {
        // default properties for created circle
        center.x = 0;
        center.y = 0;
        radius = 2;
    }
}
class PointInACircle
{
    static bool IsInCircle(Point p, Circle c)
    {
        return (p.x - c.center.x) * (p.x - c.center.x)
            + (p.y - c.center.y) * (p.y - c.center.y) <= c.radius;
    }

    static void Main()
    {
        Point myPoint = new Point();
        Circle myCircle = new Circle();
        Console.WriteLine("My circle K(({0}, {1}), {2})", 
            myCircle.center.x, myCircle.center.y, myCircle.radius);

        Console.Write("Point x: ");
        myPoint.x = double.Parse(Console.ReadLine());

        Console.Write("Point y: ");
        myPoint.y = double.Parse(Console.ReadLine());

        bool answer = IsInCircle(myPoint, myCircle);
        Console.WriteLine("Point is in the circle: {0}", answer);
    }
}