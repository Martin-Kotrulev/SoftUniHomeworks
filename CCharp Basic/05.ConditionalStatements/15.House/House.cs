using System;
//Problem 15.	* – House
//Ivaylo decided he needs a new house. Since he is not a 
//structural engineer yet, you have to help him construct 
//the building from the ground zero.
//The roof is a triangle. The walls are straight vertical lines. 
//The base is a straight horizontal line. The roof, the walls 
//and the base of the house it build of '*'. Everything 
//else is filled with '.' (see the examples below to catch the idea).
//You will be given an odd integer N, representing the width and
//the height of the house. The roof’s top starts from the center 
//(N+1)/2 and forms a triangle with base of width N. 
//The roof’s height is (N+1)/2. The distance between the roofs’ 
//end point and the walls of the building is N/4, rounded down 
//to an integer number. See the examples below 
//to understand better these formulas.

// SOLUTION CHECKED - 100%;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int roof = n / 2 + 1;
        int left = n / 2;
        int right = left;
        int bottom = n / 2;

        for (int i = 0; i < roof; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == roof - 1) Console.Write('*');
                else
                {
                    if (j == left || j == right) Console.Write('*');
                    else Console.Write('.');
                }
            }
            left--;
            right++;
            Console.WriteLine();
        }

        right = n - n / 4 - 1;
        left = n / 4;

        for (int i = 0; i < bottom; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == left || j == right ||
                    (i == bottom - 1 && j > left && j < right)) Console.Write('*');
                else Console.Write('.');
            }
            Console.WriteLine();
        }
    }
}