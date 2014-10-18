using System;
//Write a program that enters 3 real numbers and prints them 
//sorted in descending order. Use nested if statements. 
//Don’t use arrays and the built-in sorting functionality. 

class SortThreeNumbersNestedIf
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b && a > c || a > b && a == c || 
            a > c && a == b || a==b && b==c)
        {
            Console.Write(a + " ");
            if (b > c) Console.WriteLine("{0} {1}", b, c);
            else Console.WriteLine("{0} {1}", c, b);
        }
        else if (b > a && b > c || b > a && b == c || 
            b > c && b == a || a == b && b == c)
        {
            Console.Write(b + " ");
            if (a > c) Console.WriteLine("{0} {1}", a, c);
            else Console.WriteLine("{0} {1}", c, a);

        }
        else if (c > a && c > b || c > b && c == a ||
            c > a && c == b || a == b && b == c)
        {
            Console.Write(c + " ");
            if (a > b) Console.WriteLine("{0} {1}", a, b);
            else Console.WriteLine("{0} {1} ", b, a);
        }
    }
}