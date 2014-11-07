using System;
//Problem 3 – House with a Window
//Write a program to print at the console a house of 
//given size N. The roof is a triangle. The walls
//are straight vertical lines. The base is a straight
//horizontal line. The roof, the walls, the window
//and the base of the house it build of '*'. Everything
//else is filled with '.' (see the examples below).
//You will be given an integer N (N % 4 = 0). 
//The width of the house is (2*N-1), the height 
//of the house is (2*N+2). 
//The height of the roof is exactly N lines. The base 
//of the house height is (N+2). The window height is always (N/2). 
//The window width is (N-3). See the examples below 
//to understand better these formulas.

//Input
//•	The input data is read from the console.
//•	The number N stays alone at the first line.
//The input data will always be valid and in the 
//format described. There is no need to check it explicitly.

//Output
//•	The output data must be printed on the console.
//•	You should print the house on the console, 
//just like in the examples below. Each row can contain
//only the following characters: “.” (dot) and “*” (asterisk).
//Constraints
//•	N will be an integer number between 4 and 120 
//and will always be divided by 4 without reminder.
//•	Time limit: 0.25 seconds. Allowed memory: 16 MB.

//SOLUTION TESTED - 100%
class HouseWithWindow
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int innerDots = 0;
        int outerDots = n - 1;
        for (int i = 0; i < 2 * n + 2; i++)
        {
            if (i == 0)
                Console.WriteLine("{0}*{0}", new string('.', outerDots));
            else if (i > 0 && i < n)
                Console.WriteLine(
                    "{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
            else if (i == n || i == 2 * n + 1)
                Console.WriteLine("{0}", new string('*', 2 * n - 1));
            else if (i > n)
            {
                if (i <= n + n / 4 || i > (2 * n) - n / 4)
                    Console.WriteLine("*{0}*", new string('.', 2 * n - 3));
                else
                    Console.WriteLine(
                        "*{0}{1}{0}*", new string('.', n / 2), new string('*', n - 3));
            }

            if (i == 0)
            {
                outerDots--;
                innerDots++;
            }
            else
            {
                outerDots--;
                innerDots += 2;
            }
        }
    }
}