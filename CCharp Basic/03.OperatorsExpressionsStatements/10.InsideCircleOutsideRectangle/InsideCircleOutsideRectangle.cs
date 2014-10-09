using System;
//Problem 10.	Point Inside a Circle & Outside of a Rectangle
//Write an expression that checks for given point (x, y) if it is 
//within the circle K({1, 1}, 1.5) and out of 
//the rectangle R(top=1, left=-1, width=6, height=2). 

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
        // given properties for creating circle
        center.x = 1;
        center.y = 1;
        radius = 1.5;
    }
}

public class Rectangle
{
    public Point topLeft = new Point();
    public int width;
    public int height;
    public Rectangle()
    {
        // rectangle given properties
        topLeft.x = -1;
        topLeft.y = 1;
        width = 6;
        height = 2;
    }
}

class InsideCircleOutsideRectangle
{
    static bool IsInCircle(Point p, Circle c)
    {
        return (p.x - c.center.x) * (p.x - c.center.x)
            + (p.y - c.center.y) * (p.y - c.center.y) <= c.radius;
    }

    static bool IsOutOfRectangle(Point p, Rectangle r)
    {
        // is outside of top or down rectangle sides
        bool check = p.x > r.topLeft.x + r.width || p.x < r.topLeft.x ||
        p.y < r.topLeft.y - r.height || p.y > r.topLeft.y;

        return check;
    }

    static void Main()
    {
        Circle myCircle = new Circle();
        Rectangle myRectangle = new Rectangle();
        Point myPoint = new Point();

        Console.Write("x: ");
        myPoint.x = double.Parse(Console.ReadLine());

        Console.Write("y: ");
        myPoint.y = double.Parse(Console.ReadLine());

        Console.WriteLine(
            "The point is in the circle and outside the rectangle: {0}",
            IsInCircle(myPoint, myCircle) && 
            IsOutOfRectangle(myPoint, myRectangle));
    }
}