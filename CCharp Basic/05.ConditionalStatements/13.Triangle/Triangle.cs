using System;
//SOLUTION TESTED - 100%

class Triangle
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.InvariantCulture;

        int aX = int.Parse(Console.ReadLine());
        int aY = int.Parse(Console.ReadLine());
        int bX = int.Parse(Console.ReadLine());
        int bY = int.Parse(Console.ReadLine());
        int cX = int.Parse(Console.ReadLine());
        int cY = int.Parse(Console.ReadLine());

        double ab = Math.Sqrt(
            (bX - aX) * (bX - aX) +
            (bY - aY) * (bY - aY));
        double bc = Math.Sqrt(
            (bX - cX) * (bX - cX) +
            (bY - cY) * (bY - cY));
        double ca = Math.Sqrt(
            (aX - cX) * (aX - cX) +
            (aY - cY) * (aY - cY));

        if (ab + bc > ca && 
            bc + ca > ab && ab + ca > bc)
        {
            double p = (ab + bc + ca) / 2;
            double area = Math.Sqrt(p * (p - ab) *
                (p - bc) * (p - ca));
            Console.WriteLine("Yes\n{0:F2}", area);
        }
        else Console.WriteLine("No\n{0:F2}", ab);
    }
}