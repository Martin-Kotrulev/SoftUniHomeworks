using System;
using System.Collections.Generic;
//Problem 12.	* Randomize the Numbers 1…N
//Write a program that enters in integer n 
//and prints the numbers 1, 2, …, n in random order. 

class RandomiseTheNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<int, int> numbers = new Dictionary<int, int>();
        Random rnd = new Random();

        for (int i = 1; i <= n; i++)
        {
            numbers[i] = i;
        }

        while (numbers.Count > 0)
        {
            int random = rnd.Next(1, n + 1);

            if (numbers.ContainsKey(random))
            {
                Console.Write(numbers[random] + " ");
                numbers.Remove(numbers[random]);
            }
        }
        Console.WriteLine();
    }
}