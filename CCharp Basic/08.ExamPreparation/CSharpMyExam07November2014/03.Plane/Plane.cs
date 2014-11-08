using System;

class Plane
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 3 * n;
        int height = n * 3 - n / 2;
        int outerDots = (width - 1) / 2;
        int innerDots = 1;
        int underWings = 1;

        // front
        for (int i = 0; i < height - (n * 2 - 1); i++)
        {
            if (i == 0) Console.WriteLine("{0}*{0}", new string('.', outerDots));
            if (i >= 1) innerDots += 2;
            outerDots--;
            Console.WriteLine(
                "{0}*{1}*{0}", 
                new string('.', outerDots), new string('.', innerDots));
        }
        // wings
        for (int i = 0; i < n - 2; i++)
        {
            if (i < n / 2 - 1)
            {
                innerDots += 4;
                outerDots -= 2;
                Console.WriteLine(
                    "{0}*{1}*{0}", 
                    new string('.', outerDots), new string('.', innerDots));
            }
            else
            {
                if (i == n / 2 - 1)
                {
                    outerDots = n - 2;
                    innerDots = n;
                }
                else outerDots -= 2;
                if (i == n / 2 - 1) Console.WriteLine(
                    "*{0}*{1}*{0}*", 
                    new string('.', outerDots), new string('.', innerDots));
                else // wings and underwings
                {
                    Console.WriteLine(
                    "*{0}*{1}*{2}*{1}*{0}*",
                    new string('.', outerDots), 
                    new string('.', underWings), new string('.', innerDots));
                    underWings += 2;
                }
            }
        }
        // back
        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                outerDots = n - 1;
                innerDots = n;
                Console.WriteLine(
                    "{0}*{1}*{0}", 
                    new string('.', outerDots), new string('.', innerDots));
            }
            else if (i == n - 1) Console.WriteLine(new string('*', width));
            else
            {
                innerDots += 2;
                outerDots--;
                Console.WriteLine(
                    "{0}*{1}*{0}", 
                    new string('.', outerDots), new string('.', innerDots));
            }
        }
    }
}
