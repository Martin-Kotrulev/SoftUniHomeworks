using System;
//Problem 20.	** – Programmer DNA
//The secret scientists from the institute of 
//Bizarre Artificial Neurobiology or B.A.N
//have tried for years to find the DNA markers
//of the perfect programmer. The work is going 
//well but after an incident with the printer 
//in the institute it is impossible to print 
//the latest discovery. That is why they have
//asked you to help them.
//Your task is to make a program that can print
//simple DNA chains of various lengths. Simple
//DNA chains consist of sequence of diamond 
//blocks containing only letters from A to G
//(see the example on the right).
//Letters are chained alphabetically: A is 
//followed by B, then C, D, E, F, G, then again
//A and so on. Each DNA block is with size 7.
//Input
//The input data should be read from the console.
//•	On the first line an integer number N 
//specifying the length of the DNA chain will be given.
//•	On the second line the starting letter
//of the chain will be given (capital letter from A to G).
//The input data will always be valid and in 
//the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//Following the examples below print exactly N 
//lines of the programmer's DNA. Use only capital 
//letters from A to G and “.” for the empty space.
//Constraints
//•	N will always be a positive number between 7 and 999 inclusive.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.

//SOLUTION TESTED - 100%

class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char start = char.Parse(Console.ReadLine());
        int dnaSize = 7;
        int dots = dnaSize / 2;
        int letters = 1;
        int rowsCtr = 0;
        int index = 0;

        while (index < dnaSize)
        {
            //dots
            for (int j = 0; j < dots; j++) Console.Write('.');
            //letters
            for (int j = 0; j < letters; j++)
            {
                Console.Write(start);
                start++;
                if (start > 'G') start = 'A';
            }
            //dots
            for (int j = 0; j < dots; j++) Console.Write('.');

            if (index < dnaSize / 2)
            {
                letters += 2;
                dots--;
            }
            else
            {
                letters -= 2;
                dots++;
            }
            rowsCtr++;
            index++;

            Console.WriteLine();

            if (rowsCtr == n) break;
            if (index == dnaSize)
            {
                index = 0;
                dots = dnaSize / 2;
                letters = 1;
            }
        }
    }
}