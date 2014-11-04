using System;
//Problem 3 – Car

//You will be given an integer N. The width of the car is (3*N). 
//The height of the car is (3*N/2-1).  The roof height and the
//body height is exactly (N/2).  The car’s wheels height are
//(N/2-1). Check the examples below to understand your task better.

//Input
//•	Input data is read from the console.
//•	The number N stays alone at the first line.
//The input data will always be valid and in the format described. 
//There is no need to check it explicitly.

//Output
//•	The output data must be printed on the console.
//•	You must print at the console a car of size N following 
//the formulas above and the examples below.

//Constraints
//•	N will be a number between 6 and 36 and will be an even number.
//•	Time limit: 0.25 seconds.
//•	Allowed memory: 16 MB.

//SOLUTION TESTED - 100%;

class Car
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 3 * n;
        int height = 3 * (n / 2) - 1;
        int roofR = n * 2 - 1;
        int roofL = n;
        int rimsInnerL = n;
        int rimsInnerR = n * 2 - 1;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == 0 && (j >= roofL && j <= roofR)) Console.Write('*');
                else if (i == n - 1) Console.Write('*');
                else if (i < n && (j == roofL || j == roofR)) Console.Write('*');
                else if (i == n / 2 && (j < roofL || j > roofR)) Console.Write('*');
                else if (i > n - 1 && (j == rimsInnerL || j == rimsInnerR ||
                    j == roofL || j == roofR)) Console.Write('*');
                else if (i == height - 1 && ((j >= roofL && j <= rimsInnerL) ||
                    (j >= rimsInnerR && j <= roofR))) Console.Write('*');
                else Console.Write('.');
            }
            if (i < n / 2)
            {
                roofL--;
                roofR++;
            }
            else if (i == n / 2)
            {
                roofL = 0;
                roofR = width - 1;
            }
            else if (i == n - 1)
            {
                roofL = n / 2;
                roofR = width - n / 2 - 1;
            }

            Console.WriteLine();
        }
    }
}