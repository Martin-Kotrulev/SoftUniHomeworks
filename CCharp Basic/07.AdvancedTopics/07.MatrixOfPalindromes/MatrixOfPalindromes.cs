using System;
//Problem 7.	Matrix of Palindromes
//Write a program to generate the following 
//matrix of palindromes of 3 letters with 
//r rows and c columns:

class MatrixOfPalindromes
{
    static void Main(string[] args)
    {
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        string[,] matrix = new string[r, c];

        for (char i = 'a'; i < 'a' + r; i++)
        {
            for (char j = 'a'; j < 'a' + c; j++)
            {
                string current = "" + i + j + i;
                matrix[i, j] = current;
                Console.Write(current + " ");
            }
            Console.WriteLine();
        }
    }
}
