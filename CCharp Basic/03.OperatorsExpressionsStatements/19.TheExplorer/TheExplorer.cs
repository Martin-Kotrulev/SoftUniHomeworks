using System;
/* 
 Input: positive odd number 3 and 59
 * must draw:
 * Output 5:	
--*--
-*-*-
*---*
-*-*-
--*--	
 */
//SOLUTION CHECKED - 100%

class TheExplorer
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int x1pos = size / 2 + 2;
        int x2pos = size / 2 + 2;

        for (int row = 1; row <= size; row++)
        {

            for (int col = 1; col++ <= size; )
            {
                if (x1pos == col || x2pos == col) Console.Write("*");
                else Console.Write("-");
            }
            Console.WriteLine();

            if (row < size / 2 + 1)
            {
                x1pos--;
                x2pos++;
            }
            else
            {
                x1pos++;
                x2pos--;
            }
        }
    }
}