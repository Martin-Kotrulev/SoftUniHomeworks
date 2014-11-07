using System;
// TODO: Solution
class LongestAlphabeticalWord
{
    static void Main()
    {
        string word = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        char[,] table = new char[n, n];
        int index = 0;

        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                if (index > word.Length - 1) index = 0;
                table[i, j] = word[index];
                index++;
                Console.Write(table[i, j]);
            }
            Console.WriteLine();
        }



    }
}