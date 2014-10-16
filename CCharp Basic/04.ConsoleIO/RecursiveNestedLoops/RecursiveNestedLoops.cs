using System;

class RecursiveNestedLoops
{
    static int numberOfLoops;
    static int numberOfIterations;
    static int[] loops;

    static void PrintLoops()
    {
        for (int i = 0; i < numberOfLoops; i++)
        {
            Console.Write("0 ", loops[i]);
        }
        Console.WriteLine();
    }

    static void NestedLoops(int currentLoop)
    {
        if (currentLoop == numberOfLoops)
        {
            PrintLoops();
            return;
        }

        for (int ctr = 1; ctr <= numberOfIterations; ctr++)
        {
            loops[currentLoop] = ctr;
            NestedLoops(currentLoop + 1);
        }
    }

    static void Main()
    {
        numberOfLoops = int.Parse(Console.ReadLine());
        numberOfIterations = int.Parse(Console.ReadLine());

        loops = new int[numberOfLoops];

        NestedLoops(0);
    }
}