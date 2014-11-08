using System;

class BiggestOfFive
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        int max = int.MinValue;
        if (max < a) max = a;
        if (max < b) max = b;
        if (max < c) max = c;
        if (max < d) max = d;
        if (max < e) max = c;

        Console.WriteLine(max);
    }
}