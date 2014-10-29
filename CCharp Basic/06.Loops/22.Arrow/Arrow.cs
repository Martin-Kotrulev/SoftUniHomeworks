using System;
//Problem 22.	** – Arrow
//SoftUni has opened a new training center in Kaspichan, 
//but the people there did not know how to find it. 
//Your task is to print a vertical arrow, which will 
//be used to indicate the path to the new building 
//in the city. This will help thousands of people 
//to become software engineers. Please help them!

//Input
//The input data should be read from the console.
//•	On the only line will hold and integer number N 
//(always odd number), indicating the width of the arrow. 
//The input data will always be valid and in the format 
//described. There is no need to check it explicitly.
//Output
//The output should be printed on the console. Use the “#” 
//(number sign) to mark the arrow and “.” (dot) for the rest. 
//Follow the examples below.

//SOLUTION CHECKED - 100%

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int left = n / 2;
        int right = (n - 1) + (n / 2);

        // top
        Console.WriteLine(new string('.', n / 2) + 
            new string('#', n) +
            new string('.', n / 2));

        for (int i = 1; i < n * 2 - 1; i++)
        {
            // sharp part adjustments
            if (i == n)
            {
                left = 1;
                right = (n * 2) - 3;
            }

            if (i < n - 1) // base part
            {
                for (int j = 0; j < n * 2 - 1; j++)
                {
                    if (j == left || j == right) Console.Write('#');
                    else Console.Write('.');
                }
            }
            else if (i == n - 1) // middle part
            {
                for (int j = 0; j < n * 2 - 1; j++)
                {
                    if (j <= left || j >= right) Console.Write('#');
                    else Console.Write('.');
                }
            }
            else // sharp part
            {
                for (int j = 0; j < n * 2 - 1; j++)
                {
                    if (j == left || j == right) Console.Write('#');
                    else Console.Write('.');
                }
                left++;
                right--;
            }
            Console.WriteLine();
        }
    }
}